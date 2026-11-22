namespace Abstract.Factory.Models.Products.Europe
{
    public class EuEbaSwiftNotifier : FraudAlertNotifier
    {
        public string ChannelName => "EU-EBA-FraudHub";

        public void DispatchAlert(RegionTransaction tx, string decision)
            => Console.WriteLine($"[{ChannelName}] รายงานสถานะ {tx.TransactionId} ({decision}) เข้าเครือข่าย SEPA");
    }
}