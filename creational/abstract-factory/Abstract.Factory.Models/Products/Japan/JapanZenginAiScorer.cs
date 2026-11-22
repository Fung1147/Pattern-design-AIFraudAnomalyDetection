namespace Abstract.Factory.Models.Products.Japan
{
    public class JapanZenginAiScorer : FraudAiScorer
    {
        public string ModelName => "JP-Zengin-DeepAnomaly-v1";

        public double CalculateRiskScore(RegionTransaction tx)
        {
            double score = !tx.IsBiometricVerified ? 0.76 : 0.05;
            Console.WriteLine($"[{ModelName}] วิเคราะห์ธุรกรรม {tx.TransactionId} -> Risk Score: {score:F2}");
            return score;
        }
    }
}