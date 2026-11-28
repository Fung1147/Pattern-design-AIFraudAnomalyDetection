using Builder.Models.Products;

namespace Builder.Models.Builders
{
    public class MoneyLaunderingBuilder : FraudModelBuilder
    {
        private MoneyLaundering _model = new();

        public MoneyLaunderingBuilder() => Reset();

        public void Reset() => _model = new MoneyLaundering();

        public void SetTierMetadata(string modelId, string tierLevel)
        {
            _model.ModelId = modelId;
            _model.TierLevel = tierLevel;
        }

        public void BuildDataIngestion()
            => _model.DataIngestionSource = "Neo4j Graph Lakehouse & Cross-Bank Ledger";

        public void BuildFeatureEngineering()
            => _model.FeatureEngineeringPipeline = "Mule Ring Centrality & Structuring Pattern";

        public void BuildCoreAlgorithm(string tier)
            => _model.CoreAlgorithm = tier == "Enterprise" ? "Graph Neural Network (GraphSAGE)" : "Louvain Community Detection";

        public void BuildThresholdAndDomainSpecs(double threshold, string tier)
        {
            _model.RiskThreshold = threshold;
            _model.GraphTraversalHops = tier == "Lightweight" ? 2 : (tier == "Standard" ? 4 : 7);
            _model.RegulatoryRuleSet = tier == "Enterprise" ? "BOT-FR-2026 + AMLO + FinCEN BSA" : "BOT-FR-2026 Basic";
        }

        public void BuildExplainabilityModule(bool enableXai)
            => _model.IsExplainableAiEnabled = enableXai;

        public void BuildAlertIntegration()
            => _model.AlertIntegrationChannel = "AOC 1441 Mule Freeze & SAR Auto-Filing";

        public MoneyLaundering GetResult()
        {
            MoneyLaundering result = _model;
            Reset();
            return result;
        }
    }
}