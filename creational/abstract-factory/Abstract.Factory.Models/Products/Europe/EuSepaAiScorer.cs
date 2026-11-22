namespace Abstract.Factory.Models.Products.Europe
{
    public class EuSepaAiScorer : FraudAiScorer
    {
        public string ModelName => "EU-SEPA-Transformer-v2";

        public double CalculateRiskScore(RegionTransaction tx)
        {
            double score = tx.Amount >= 1000m ? 0.45 : 0.08;
            Console.WriteLine($"[{ModelName}] วิเคราะห์ธุรกรรม {tx.TransactionId} -> Risk Score: {score:F2}");
            return score;
        }
    }
}