
namespace PeerToPeerWebService.Models.Requests
{
    public class RegisterRequest
    {
        public int ID { get; set; } 
        public string IPAddress { get; set; }
        public int Port { get; set; }
    }
}
