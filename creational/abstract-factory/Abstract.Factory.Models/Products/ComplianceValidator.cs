namespace Abstract.Factory.Models.Products
{
    public interface ComplianceValidator
    {
        string RegulationCode { get; }
        bool ValidateCompliance(RegionTransaction tx);
    }
}