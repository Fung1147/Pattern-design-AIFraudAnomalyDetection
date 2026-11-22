namespace Abstract.Factory.Models.Products.Japan
{
    public class FsaAppiValidator : ComplianceValidator
    {
        public string RegulationCode => "JP-FSA / APPI-Security";

        public bool ValidateCompliance(RegionTransaction tx)
        {
            bool passed = tx.IsBiometricVerified;
            Console.WriteLine($"[{RegulationCode}] ตรวจสอบมาตรฐานความปลอดภัย FSA ญี่ปุ่น: {(passed ? "ผ่าน" : "ไม่ผ่าน")}");
            return passed;
        }
    }
}