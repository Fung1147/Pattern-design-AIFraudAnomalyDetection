namespace Abstract.Factory.Models
{
    public class RegionTransaction
    {
        public string TransactionId { get; set; }
        public string RegionCode { get; set; }
        public decimal Amount { get; set; }
        public bool IsBiometricVerified { get; set; }

        public RegionTransaction(string txId, string regionCode, decimal amount, bool isBiometricVerified)
        {
            TransactionId = txId;
            RegionCode = regionCode;
            Amount = amount;
            IsBiometricVerified = isBiometricVerified;
        }
    }
}