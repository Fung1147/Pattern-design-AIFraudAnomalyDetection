using Builder.Models.Products;

namespace Builder.Models.Builders
{
    public class AccountTakeoverBuilder : FraudModelBuilder
    {
        private AccountTakeover _model = new();

        public AccountTakeoverBuilder() => Reset();

        public void Reset() => _model = new AccountTakeover();

        public void SetTierMetadata(string modelId, string tierLevel)
        {
            _model.ModelId = modelId;
            _model.TierLevel = tierLevel;
        }

        public void BuildDataIngestion()
            => _model.DataIngestionSource = "Mobile SDK Telemetry & Auth Session Logs";

        public void BuildFeatureEngineering()
            => _model.FeatureEngineeringPipeline = "Session Anomaly & IP Reputation Embedding";

        public void BuildCoreAlgorithm(string tier)
            => _model.CoreAlgorithm = tier == "Enterprise" ? "Siamese Neural Network + Autoencoder" : "Isolation Forest";

        public void BuildThresholdAndDomainSpecs(double threshold, string tier)
        {
            _model.RiskThreshold = threshold;
            _model.DeviceFingerprintDepth = tier == "Lightweight" ? "Basic HTTP/OS Header" : "Deep Canvas, WebGL & Sensor Entropy";
            _model.RequiresBehavioralBiometrics = tier != "Lightweight";
        }

        public void BuildExplainabilityModule(bool enableXai)
            => _model.IsExplainableAiEnabled = enableXai;

        public void BuildAlertIntegration()
            => _model.AlertIntegrationChannel = "Session Force-Logout & Face Liveness Challenge";

        public AccountTakeover GetResult()
        {
            AccountTakeover result = _model;
            Reset();
            return result;
        }
    }
}