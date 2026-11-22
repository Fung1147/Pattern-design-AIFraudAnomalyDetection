using Abstract.Factory.Models.Products;
using Abstract.Factory.Models.Products.Europe;

namespace Abstract.Factory.Models.Factories
{
    public class EuropeFraudFactory : RegionalFraudFactory
    {
        public FraudAiScorer CreateAiScorer() => new EuSepaAiScorer();
        public ComplianceValidator CreateComplianceValidator() => new GdprPsd2Validator();
        public FraudAlertNotifier CreateAlertNotifier() => new EuEbaSwiftNotifier();
    }
}