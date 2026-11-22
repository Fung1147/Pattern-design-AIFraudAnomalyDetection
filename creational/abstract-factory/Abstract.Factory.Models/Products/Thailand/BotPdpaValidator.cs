namespace Abstract.Factory.Models.Products.Thailand
{
    public class BotPdpaValidator : ComplianceValidator
    {
        public string RegulationCode => "BOT-FR-2026 / PDPA";

        public bool ValidateCompliance(RegionTransaction tx)
        {
            bool passed = !(tx.Amount >= 50000m && !tx.IsBiometricVerified);
            Console.WriteLine($"[{RegulationCode}] ตรวจสอบสแกนใบหน้า ธปท. (ยอด >= 50,000): {(passed ? "ผ่าน" : "ไม่ผ่าน")}");
            return passed;
        }
    }
}