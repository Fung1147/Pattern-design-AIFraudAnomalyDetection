namespace Factory.Method.Models.Products
{
    public class CryptoExtractor : TransactionExtractor
    {
        public string ChannelType { get; } = "WEB3_CRYPTO";
        private string _network = "Ethereum Mainnet";

        public void ParseData(TransactionData data)
            => Console.WriteLine($"[{ChannelType}] ดึงข้อมูลบน {_network} รายการ {data.TransactionId} มูลค่า {data.Amount:N2} บาท");

        public void MaskPii(TransactionData data)
        {
            data.AccountId = data.AccountId[..6] + "..." + data.AccountId[^4..];
            Console.WriteLine($"[{ChannelType}] เข้ารหัส Wallet Address -> {data.AccountId}");
        }

        public void ExtractFeatures(TransactionData data)
        {
            data.AiFeatures["mixer_risk_score"] = 0.85;
            data.AiFeatures["gas_anomaly"] = 1.4;
            data.AiFeatures["wallet_age_days"] = 2;
            Console.WriteLine($"[{ChannelType}] สกัด Feature สำเร็จ: {data.AiFeatures.Count} ตัวแปร");
        }
    }
}