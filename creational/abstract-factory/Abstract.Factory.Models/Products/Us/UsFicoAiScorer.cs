namespace Abstract.Factory.Models.Products.Us
{
    public class UsFicoAiScorer : FraudAiScorer
    {
        public string ModelName => "US-FICO-FalconNeural-v5";

        public double CalculateRiskScore(RegionTransaction tx)
        {
            double score = tx.Amount >= 10000m ? 0.88 : 0.12;
            Console.WriteLine($"[{ModelName}] วิเคราะห์ธุรกรรม {tx.TransactionId} -> Risk Score: {score:F2}");
            return score;
        }
    }
}