namespace Abstract.Factory.Models.Products
{
    public interface FraudAiScorer
    {
        string ModelName { get; }
        double CalculateRiskScore(RegionTransaction tx);
    }
}