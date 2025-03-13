using System;
using System.ComponentModel.DataAnnotations;

namespace PeerToPeerWebService.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string IPAddress { get; set; }

        [Required]
        public int Port { get; set; }

        public DateTime LastUpdated { get; set; }

        public int JobsCompleted { get; set; }
    }
}
