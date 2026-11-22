namespace Factory.Method.Models
{
    public class TransactionData
    {
        public string TransactionId { get; set; }
        public string AccountId { get; set; }
        public decimal Amount { get; set; }
        public Dictionary<string, double> AiFeatures { get; set; } = new();

        public TransactionData(string txId, string accountId, decimal amount)
        {
            TransactionId = txId;
            AccountId = accountId;
            Amount = amount;
        }
    }
}