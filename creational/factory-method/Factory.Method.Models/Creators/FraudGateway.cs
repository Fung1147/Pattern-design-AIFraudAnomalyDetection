using Factory.Method.Models.Products;

namespace Factory.Method.Models.Creators
{
    public abstract class FraudGateway
    {
        public string GatewayId { get; }
        private string AiEndpoint { get; }

        protected FraudGateway(string gatewayId, string aiEndpoint)
        {
            GatewayId = gatewayId;
            AiEndpoint = aiEndpoint;
        }

        protected abstract TransactionExtractor CreateExtractor();

        public void ProcessTransaction(TransactionData data)
        {
            Console.WriteLine($"Gateway: {GatewayId} เริ่มทำงาน");
            TransactionExtractor extractor = CreateExtractor();

            extractor.ParseData(data);
            extractor.MaskPii(data);
            extractor.ExtractFeatures(data);

            Console.WriteLine($"-> ส่ง Features ({data.AiFeatures.Count} ตัว) ไปที่ {AiEndpoint}\n");
        }
    }
}