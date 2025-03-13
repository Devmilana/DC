namespace BankDataService.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}