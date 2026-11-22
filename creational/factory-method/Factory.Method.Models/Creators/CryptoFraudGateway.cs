using Factory.Method.Models.Products;

namespace Factory.Method.Models.Creators
{
    public class CryptoFraudGateway : FraudGateway
    {
        public CryptoFraudGateway() : base("GW-WEB3-01", "https://ai.internal/v1/score/crypto") { }
        protected override TransactionExtractor CreateExtractor() => new CryptoExtractor();
    }
}