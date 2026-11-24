using Builder.Models.Products;

namespace Builder.Models.Builders
{
    public class TransactionFraudBuilder : FraudModelBuilder
    {
        private TransactionFraud _model = new();

        public TransactionFraudBuilder() => Reset();

        public void Reset() => _model = new TransactionFraud();

        public void SetTierMetadata(string modelId, string tierLevel)
        {
            _model.ModelId = modelId;
            _model.TierLevel = tierLevel;
        }

        public void BuildDataIngestion()
            => _model.DataIngestionSource = "Apache Kafka Real-Time Payment Stream";

        public void BuildFeatureEngineering()
            => _model.FeatureEngineeringPipeline = "Rolling Spend Aggregation & Geo-Velocity";

        public void BuildCoreAlgorithm(string tier)
            => _model.CoreAlgorithm = tier == "Enterprise" ? "Ensemble (XGBoost + DeepTabNet)" : "LightGBM Fast-Tree";

        public void BuildThresholdAndDomainSpecs(double threshold, string tier)
        {
            _model.RiskThreshold = threshold;
            _model.VelocityWindowSeconds = tier == "Lightweight" ? 60 : 3600;
            _model.SupportedPaymentRails = tier == "Lightweight" ? "PromptPay / QR" : "PromptPay, SWIFT, Visa/Mastercard";
        }

        public void BuildExplainabilityModule(bool enableXai)
            => _model.IsExplainableAiEnabled = enableXai;

        public void BuildAlertIntegration()
            => _model.AlertIntegrationChannel = "Real-Time Card Decline & SMS OTP Trigger";

        public TransactionFraud GetResult()
        {
            TransactionFraud result = _model;
            Reset();
            return result;
        }
    }
}