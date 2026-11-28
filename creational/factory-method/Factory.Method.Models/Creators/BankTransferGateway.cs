using Factory.Method.Models.Products;

namespace Factory.Method.Models.Creators
{
    public class BankTransferGateway : FraudGateway
    {
        public BankTransferGateway() : base("GW-BANK-TH02", "https://ai.internal/v1/score/transfer") { }
        protected override TransactionExtractor CreateExtractor() => new BankTransferExtractor();
    }
}