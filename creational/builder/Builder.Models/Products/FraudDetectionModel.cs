namespace Builder.Models.Products
{
    public abstract class FraudDetectionModel
    {
        public string ModelId { get; set; } = string.Empty;
        public string TierLevel { get; set; } = string.Empty;
        public string DataIngestionSource { get; set; } = string.Empty;
        public string FeatureEngineeringPipeline { get; set; } = string.Empty;
        public string CoreAlgorithm { get; set; } = string.Empty;
        public double RiskThreshold { get; set; }
        public bool IsExplainableAiEnabled { get; set; }
        public string AlertIntegrationChannel { get; set; } = string.Empty;

        public virtual void DisplaySpecifications()
        {
            Console.WriteLine($"==================================================");
            Console.WriteLine($"Model ID    : {ModelId} [{TierLevel}]");
            Console.WriteLine($"Ingestion   : {DataIngestionSource}");
            Console.WriteLine($"Features    : {FeatureEngineeringPipeline}");
            Console.WriteLine($"Algorithm   : {CoreAlgorithm} (Threshold: {RiskThreshold:F2})");
            Console.WriteLine($"Explainable : {(IsExplainableAiEnabled ? "Enabled (SHAP/LIME)" : "Disabled (Fast Inference)")}");
            Console.WriteLine($"Alerting    : {AlertIntegrationChannel}");
        }
    }
}