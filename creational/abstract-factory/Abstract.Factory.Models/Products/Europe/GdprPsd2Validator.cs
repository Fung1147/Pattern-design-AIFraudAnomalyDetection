namespace Abstract.Factory.Models.Products.Europe
{
    public class GdprPsd2Validator : ComplianceValidator
    {
        public string RegulationCode => "EU-GDPR / PSD2-SCA";

        public bool ValidateCompliance(RegionTransaction tx)
        {
            bool passed = tx.IsBiometricVerified;
            Console.WriteLine($"[{RegulationCode}] ตรวจสอบ Strong Customer Authentication (SCA): {(passed ? "ผ่าน" : "ไม่ผ่าน")}");
            return passed;
        }
    }
}