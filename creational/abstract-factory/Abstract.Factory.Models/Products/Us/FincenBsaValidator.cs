namespace Abstract.Factory.Models.Products.Us
{
    public class FincenBsaValidator : ComplianceValidator
    {
        public string RegulationCode => "US-FinCEN / BSA-AML";

        public bool ValidateCompliance(RegionTransaction tx)
        {
            bool passed = tx.Amount < 10000m || tx.IsBiometricVerified;
            Console.WriteLine($"[{RegulationCode}] ตรวจสอบเกณฑ์ฟอกเงิน BSA ($10,000): {(passed ? "ผ่าน" : "ต้องยื่น SAR")}");
            return passed;
        }
    }
}