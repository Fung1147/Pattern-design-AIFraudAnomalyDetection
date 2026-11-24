namespace Builder.Models.Products
{
    public class TransactionFraud : FraudDetectionModel
    {
        public int VelocityWindowSeconds { get; set; }
        public string SupportedPaymentRails { get; set; } = string.Empty;

        public override void DisplaySpecifications()
        {
            base.DisplaySpecifications();
            Console.WriteLine($"[Tx Specific] Velocity Window : {VelocityWindowSeconds} sec");
            Console.WriteLine($"[Tx Specific] Payment Rails   : {SupportedPaymentRails}");
            Console.WriteLine($"==================================================\n");
        }
    }
}