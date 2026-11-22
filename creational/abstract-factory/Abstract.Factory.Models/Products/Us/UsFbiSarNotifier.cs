namespace Abstract.Factory.Models.Products.Us
{
    public class UsFbiSarNotifier : FraudAlertNotifier
    {
        public string ChannelName => "US-FinCEN-SAR-Portal";

        public void DispatchAlert(RegionTransaction tx, string decision)
            => Console.WriteLine($"[{ChannelName}] บันทึก Suspicious Activity Report ({decision}) สำหรับ {tx.TransactionId}");
    }
}