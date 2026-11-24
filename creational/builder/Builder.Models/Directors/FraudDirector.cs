using Builder.Models.Builders;

namespace Builder.Models.Directors
{
    public class FraudDirector
    {
        // Lightweight (Edge / Mobile)
        public void ConstructLightweightModel(FraudModelBuilder builder, string modelId)
        {
            builder.Reset();
            builder.SetTierMetadata(modelId, "Lightweight");
            builder.BuildDataIngestion();
            builder.BuildFeatureEngineering();
            builder.BuildCoreAlgorithm("Lightweight");
            builder.BuildThresholdAndDomainSpecs(0.85, "Lightweight");
            builder.BuildExplainabilityModule(false);
            builder.BuildAlertIntegration();
        }

        // Standard (Cloud)
        public void ConstructStandardModel(FraudModelBuilder builder, string modelId)
        {
            builder.Reset();
            builder.SetTierMetadata(modelId, "Standard");
            builder.BuildDataIngestion();
            builder.BuildFeatureEngineering();
            builder.BuildCoreAlgorithm("Standard");
            builder.BuildThresholdAndDomainSpecs(0.75, "Standard");
            builder.BuildExplainabilityModule(true);
            builder.BuildAlertIntegration();
        }

        // Enterprise (Deep AI)
        public void ConstructEnterpriseModel(FraudModelBuilder builder, string modelId)
        {
            builder.Reset();
            builder.SetTierMetadata(modelId, "Enterprise");
            builder.BuildDataIngestion();
            builder.BuildFeatureEngineering();
            builder.BuildCoreAlgorithm("Enterprise");
            builder.BuildThresholdAndDomainSpecs(0.65, "Enterprise");
            builder.BuildExplainabilityModule(true);
            builder.BuildAlertIntegration();
        }
    }
}