using Factory.Method.Models.Products;

namespace Factory.Method.Models.Creators
{
    public class CreditCardFraudGateway : FraudGateway
    {
        public CreditCardFraudGateway() : base("GW-CARD-TH01", "https://ai.internal/v1/score/card") { }
        protected override TransactionExtractor CreateExtractor() => new CreditCardExtractor();
    }
}