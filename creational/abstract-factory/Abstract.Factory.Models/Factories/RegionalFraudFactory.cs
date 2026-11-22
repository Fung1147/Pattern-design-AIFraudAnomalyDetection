using Abstract.Factory.Models.Products;

namespace Abstract.Factory.Models.Factories
{
    public interface RegionalFraudFactory
    {
        FraudAiScorer CreateAiScorer();
        ComplianceValidator CreateComplianceValidator();
        FraudAlertNotifier CreateAlertNotifier();
    }
}