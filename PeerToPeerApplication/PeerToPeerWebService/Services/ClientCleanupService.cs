using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PeerToPeerWebService.Models;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PeerToPeerWebService.Services
{
    public class ClientCleanupService : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<ClientCleanupService> _logger;

        public ClientCleanupService(IServiceProvider serviceProvider, ILogger<ClientCleanupService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            // Run every minute
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ClientContext>();

                var threshold = DateTime.UtcNow.AddMinutes(-2); // Clients not seen in last 2 minutes

                var deadClients = context.Clients.Where(c => c.LastUpdated < threshold).ToList();

                if (deadClients.Any())
                {
                    context.Clients.RemoveRange(deadClients);
                    context.SaveChanges();

                    _logger.LogInformation("Removed {Count} dead clients", deadClients.Count);
                }

                if (!context.Clients.Any())
                {
                    try
                    {
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Clients', RESEED, 0);");
                        _logger.LogInformation("Identity seed reset as there are no clients");
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error resetting identity seed");
                    }
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
