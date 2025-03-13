namespace BankDataService.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}