using Abstract.Factory.Models.Factories;
using Abstract.Factory.Models.Products;

namespace Abstract.Factory.Models
{
    public class Client
    {
        private RegionalFraudFactory _factory;
        private FraudAiScorer? _aiScorer;
        private ComplianceValidator? _validator;
        private FraudAlertNotifier? _notifier;

        public Client(RegionalFraudFactory factory)
        {
            _factory = factory;
        }

        public void CreateSuite()
        {
            _aiScorer = _factory.CreateAiScorer();
            _validator = _factory.CreateComplianceValidator();
            _notifier = _factory.CreateAlertNotifier();
        }

        public void SetFactory(RegionalFraudFactory factory)
        {
            _factory = factory;
            CreateSuite();
        }

        public void ProcessTransaction(RegionTransaction tx)
        {
            if (_aiScorer == null || _validator == null || _notifier == null)
            {
                CreateSuite();
            }

            Console.WriteLine($"--- ตรวจสอบรายการ {tx.TransactionId} (ภูมิภาค: {tx.RegionCode}) ---");
            bool isCompliant = _validator!.ValidateCompliance(tx);
            double riskScore = _aiScorer!.CalculateRiskScore(tx);

            string decision = (!isCompliant || riskScore > 0.80) ? "REJECT / FREEZE" : "APPROVE";
            _notifier!.DispatchAlert(tx, decision);
            Console.WriteLine($"--> ผลการตัดสินใจระบบ: {decision}\n");
        }
    }
}