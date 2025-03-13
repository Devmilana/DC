using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PeerToPeerWebService.Models;
using PeerToPeerWebService.Models.Requests;

namespace PeerToPeerWebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly ClientContext _context;

        public ClientsController(ClientContext context)
        {
            _context = context;
        }

        // POST: api/Clients/Register
        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.IPAddress) || request.Port <= 0)
            {
                return BadRequest("Invalid IP address or port");
            }

            var client = _context.Clients.FirstOrDefault(c => c.IPAddress == request.IPAddress && c.Port == request.Port);

            if (client == null)
            {
                client = new Client
                {
                    IPAddress = request.IPAddress,
                    Port = request.Port,
                    LastUpdated = DateTime.UtcNow
                };
                _context.Clients.Add(client);
                _context.SaveChanges(); // Save to generate the ID
            }
            else
            {
                client.LastUpdated = DateTime.UtcNow;
                _context.SaveChanges();
            }

            // Return the client ID
            return Ok(new { client.Id });
        }

        // GET: api/Clients/List
        [HttpGet("List")]
        public IActionResult List()
        {
            var clients = _context.Clients.ToList();
            return Ok(clients);
        }

        // POST: api/Clients/JobComplete
        [HttpPost("JobComplete")]
        public IActionResult JobComplete([FromBody] JobCompleteRequest request)
        {
            if (request == null || request.ClientId <= 0)
            {
                return BadRequest("Invalid client ID");
            }

            var client = _context.Clients.FirstOrDefault(c => c.Id == request.ClientId);

            if (client == null)
            {
                return NotFound("Client not found");
            }

            // Update last updated time
            client.LastUpdated = DateTime.UtcNow;

            // Increment jobs completed
            client.JobsCompleted++;

            _context.SaveChanges();

            return Ok();
        }

        // GET: api/Clients/{id}
        [HttpGet("{id}")]
        public IActionResult GetClientById(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);

            if (client == null)
            {
                return NotFound("Client not found");
            }

            return Ok(client);
        }

        // GET: api/Clients/SearchByIP/{ipAddress}
        [HttpGet("SearchByIP/{ipAddress}")]
        public IActionResult SearchByIPAddress(string ipAddress)
        {
            if (string.IsNullOrEmpty(ipAddress))
            {
                return BadRequest("IP address is required");
            }

            var clients = _context.Clients.Where(c => c.IPAddress == ipAddress).ToList();

            if (!clients.Any())
            {
                return NotFound("No clients found with the specified IP address");
            }

            return Ok(clients);
        }

        // GET: api/Clients/SearchByPort/{port}
        [HttpGet("SearchByPort/{port}")]
        public IActionResult SearchByPort(int port)
        {
            if (port <= 0)
            {
                return BadRequest("Invalid port number");
            }

            var clients = _context.Clients.Where(c => c.Port == port).ToList();

            if (!clients.Any())
            {
                return NotFound("No clients found with the specified port");
            }

            return Ok(clients);
        }

        // POST: api/Clients/Heartbeat
        [HttpPost("Heartbeat")]
        public IActionResult Heartbeat([FromBody] HeartbeatRequest request)
        {
            if (request == null || request.ClientId <= 0)
            {
                return BadRequest("Invalid client ID");
            }

            var client = _context.Clients.FirstOrDefault(c => c.Id == request.ClientId);

            if (client == null)
            {
                return NotFound("Client not found");
            }

            // Update last updated time
            client.LastUpdated = DateTime.UtcNow;

            _context.SaveChanges();

            return Ok();
        }

        // POST: api/Clients/Deregister
        [HttpPost("Deregister")]
        public IActionResult Deregister([FromBody] DeregisterRequest request)
        {
            if (request == null || request.ClientId <= 0)
            {
                return BadRequest("Invalid client ID");
            }

            var client = _context.Clients.FirstOrDefault(c => c.Id == request.ClientId);

            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }

            return Ok();
        }

    }
}
