namespace Builder.Models.Builders
{
    public interface FraudModelBuilder
    {
        void Reset();
        void SetTierMetadata(string modelId, string tierLevel);
        void BuildDataIngestion();
        void BuildFeatureEngineering();
        void BuildCoreAlgorithm(string tier);
        void BuildThresholdAndDomainSpecs(double threshold, string tier);
        void BuildExplainabilityModule(bool enableXai);
        void BuildAlertIntegration();
    }
}