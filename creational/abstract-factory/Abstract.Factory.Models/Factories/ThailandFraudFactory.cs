using Abstract.Factory.Models.Products;
using Abstract.Factory.Models.Products.Thailand;

namespace Abstract.Factory.Models.Factories
{
    public class ThailandFraudFactory : RegionalFraudFactory
    {
        public FraudAiScorer CreateAiScorer() => new ThaiBehaviorAiScorer();
        public ComplianceValidator CreateComplianceValidator() => new BotPdpaValidator();
        public FraudAlertNotifier CreateAlertNotifier() => new ThaiPromptPayNotifier();
    }
}