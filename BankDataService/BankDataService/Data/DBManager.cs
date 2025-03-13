using System;
using System.Collections.Generic;
using System.Security.Principal;
using BankDataService.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Drawing;
using System.IO;
using System.Text;

namespace BankDataService.Data
{
    public class DBManager : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        private Random _random = new Random();

        // Arrays for random data generation
        private string[] firstNames = { "John", "Jane", "Michael", "Sarah", "Robert", "Emily", "David", "Laura", "James", "Olivia" };
        private string[] lastNames = { "Smith", "Johnson", "Brown", "Williams", "Jones", "Garcia", "Miller", "Davis", "Martinez", "Taylor" };
        private string[] streets = { "Main St", "Highland Ave", "Maple St", "Oak St", "Elm St", "Pine St", "Cedar Ave", "Walnut St", "Cherry St", "Birch St" };
        private string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio", "San Diego", "Dallas", "San Jose" };

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = BankData.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding data with random values
            try
            {
                List<UserProfile> userProfiles = GenerateRandomUserProfiles(10);
                List<Account> accounts = GenerateRandomAccounts(userProfiles);
                List<Transaction> transactions = GenerateRandomTransactions(accounts);

                // Apply seeded data
                modelBuilder.Entity<Account>().HasData(accounts);
                modelBuilder.Entity<Transaction>().HasData(transactions);
                modelBuilder.Entity<UserProfile>().HasData(userProfiles);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding data: {ex.Message}");
            }
        }

        private List<Transaction> GenerateRandomTransactions(List<Account> accounts)
        {
            var transactions = new List<Transaction>();
            int transactionId = 1;

            foreach (var account in accounts)
            {
                int numOfTransactions = _random.Next(1, 5);
                // Each account has 1 - 4 transactions
                for (int i = 0; i < numOfTransactions; i++)
                {
                    decimal amount = _random.Next(50, 1000);
                    string type = _random.Next(0, 2) == 0 ? "Deposit" : "Withdrawal";

                    if (type == "Withdrawal" && account.Balance < amount)
                    {
                        amount = account.Balance; // Limit withdrawal if insufficient balance
                    }

                    transactions.Add(new Transaction
                    {
                        TransactionId = transactionId++,
                        AccountId = account.AccountId,
                        Amount = amount,
                        TransactionDate = DateTime.Today.AddDays(-_random.Next(0, 365)),
                        TransactionType = type
                    });

                    // Adjust account balance based on transaction
                    if (type == "Deposit")
                    {
                        account.Balance += amount;
                    }
                    else if (type == "Withdrawal")
                    {
                        account.Balance -= amount;
                    }
                }
            }
            return transactions;
        }

        // Generate random accounts for each user profile
        private List<Account> GenerateRandomAccounts(List<UserProfile> userProfiles)
        {
            var accounts = new List<Account>();
            foreach (var profile in userProfiles)
            {
                accounts.Add(new Account
                {
                    AccountId = profile.UserProfileId,
                    AccountHolderName = profile.Name,
                    Balance = _random.Next(1000, 10000),
                    CreatedAt = DateTime.Today.AddDays(-_random.Next(0, 365))
                });
            }
            return accounts;
        }

        // Generate random user profiles
        private List<UserProfile> GenerateRandomUserProfiles(int count)
        {
            var generatedNames = new HashSet<string>(); // Track generated names
            var userProfiles = new List<UserProfile>();
            for (int i = 1; i <= count; i++)
            {
                string firstName = firstNames[_random.Next(firstNames.Length)];
                string lastName = lastNames[_random.Next(lastNames.Length)];
                string fullName = $"{firstName} {lastName}";

                if (generatedNames.Contains(fullName))
                {
                    i--;
                    continue; // If it exists, skip to the next iteration
                }

                string street = streets[_random.Next(streets.Length)];
                string city = cities[_random.Next(cities.Length)];
                string address = $"{_random.Next(100, 999)} {street}, {city}";

                string email = $"{firstName.ToLower()}.{lastName.ToLower()}@gmail.com";
                string phone = $"{_random.Next(100, 999)}-{_random.Next(100, 999)}-{_random.Next(1000, 9999)}";

                // Generate the first letter for the profile picture
                string pictureBase64 = GenerateLetterImageAsBase64(firstName[0]);
                // Hash the password before storing
                string password = $"password{firstName}";

                generatedNames.Add(fullName);
                userProfiles.Add(new UserProfile
                {
                    UserProfileId = i,
                    Name = fullName,
                    Email = email,
                    Address = address,
                    Phone = phone,
                    Picture = pictureBase64,
                    Password = password,
                    IsAdmin = false
                });
            }

            userProfiles[0].IsAdmin = true;
            return userProfiles;
        }

        // Generate a letter image as base64 string
        public static string GenerateLetterImageAsBase64(char letter)
        {
            Bitmap bitmap = new Bitmap(126, 126);
            string image;

            try
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White);  // Background color
                    using (var font = new Font("Liberation Mono", 95))
                    {
                        using (var brush = new SolidBrush(Color.Black))
                        {
                            g.DrawString(letter.ToString().ToUpper(), font, brush, 0, 0);
                        }
                    }

                    image = ConvertBitmapToBase64(bitmap);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating image: {ex.Message}");
                image = null; 
            }

            return image;
        }

        // Convert bitmap to base64 string
        private static string ConvertBitmapToBase64(Bitmap bitmap)
        {
            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = memoryStream.ToArray();
                    return Convert.ToBase64String(imageBytes); // Return the base64 string of the image
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting bitmap to base64: {ex.Message}");
                return null; 
            }
        }

        // Hash the password using SHA256
        public static string HashPassword(string password)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error hashing password: {ex.Message}");
                return null;
            }
        }
    }
}