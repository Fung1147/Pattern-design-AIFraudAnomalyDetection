namespace Abstract.Factory.Models.Products.Thailand
{
    public class ThaiPromptPayNotifier : FraudAlertNotifier
    {
        public string ChannelName => "TH-AOC-1441-Webhook";

        public void DispatchAlert(RegionTransaction tx, string decision)
            => Console.WriteLine($"[{ChannelName}] ส่งข้อมูลรายการ {tx.TransactionId} ({decision}) เข้าศูนย์ AOC 1441");
    }
}