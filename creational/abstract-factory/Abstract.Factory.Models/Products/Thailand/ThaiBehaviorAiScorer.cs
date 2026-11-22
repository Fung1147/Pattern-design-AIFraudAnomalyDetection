namespace Abstract.Factory.Models.Products.Thailand
{
    public class ThaiBehaviorAiScorer : FraudAiScorer
    {
        public string ModelName => "TH-MuleAccount-XGBoost-v3";

        public double CalculateRiskScore(RegionTransaction tx)
        {
            double score = tx.Amount >= 50000m && !tx.IsBiometricVerified ? 0.92 : 0.15;
            Console.WriteLine($"[{ModelName}] วิเคราะห์ธุรกรรม {tx.TransactionId} -> Risk Score: {score:F2}");
            return score;
        }
    }
}