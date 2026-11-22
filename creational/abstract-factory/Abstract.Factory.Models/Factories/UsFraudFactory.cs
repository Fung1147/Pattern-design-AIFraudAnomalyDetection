using Abstract.Factory.Models.Products;
using Abstract.Factory.Models.Products.Us;

namespace Abstract.Factory.Models.Factories
{
    public class UsFraudFactory : RegionalFraudFactory
    {
        public FraudAiScorer CreateAiScorer() => new UsFicoAiScorer();
        public ComplianceValidator CreateComplianceValidator() => new FincenBsaValidator();
        public FraudAlertNotifier CreateAlertNotifier() => new UsFbiSarNotifier();
    }
}