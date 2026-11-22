namespace Abstract.Factory.Models.Products.Japan
{
    public class JapanJfsaNotifier : FraudAlertNotifier
    {
        public string ChannelName => "JP-JFSA-AlertSystem";

        public void DispatchAlert(RegionTransaction tx, string decision)
            => Console.WriteLine($"[{ChannelName}] แจ้งเตือนระบบเฝ้าระวัง JFSA ({decision}) รายการ {tx.TransactionId}");
    }
}