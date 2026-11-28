using Factory.Method.Models.Products;

namespace Factory.Method.Models.Creators
{
    public class CryptoGateway : FraudGateway
    {
        public CryptoGateway() : base("GW-WEB3-01", "https://ai.internal/v1/score/crypto") { }
        protected override TransactionExtractor CreateExtractor() => new CryptoExtractor();
    }
}