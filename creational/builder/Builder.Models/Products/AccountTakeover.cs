namespace Builder.Models.Products
{
    public class AccountTakeover : FraudDetectionModel
    {
        public string DeviceFingerprintDepth { get; set; } = string.Empty;
        public bool RequiresBehavioralBiometrics { get; set; }

        public override void DisplaySpecifications()
        {
            base.DisplaySpecifications();
            Console.WriteLine($"[ATO Specific] Device Fingerprint : {DeviceFingerprintDepth}");
            Console.WriteLine($"[ATO Specific] Keystroke/Biometric: {(RequiresBehavioralBiometrics ? "Active" : "Off")}");
            Console.WriteLine($"==================================================\n");
        }
    }
}