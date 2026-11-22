using Abstract.Factory.Models.Products;
using Abstract.Factory.Models.Products.Japan;

namespace Abstract.Factory.Models.Factories
{
    public class JapanFraudFactory : RegionalFraudFactory
    {
        public FraudAiScorer CreateAiScorer() => new JapanZenginAiScorer();
        public ComplianceValidator CreateComplianceValidator() => new FsaAppiValidator();
        public FraudAlertNotifier CreateAlertNotifier() => new JapanJfsaNotifier();
    }
}