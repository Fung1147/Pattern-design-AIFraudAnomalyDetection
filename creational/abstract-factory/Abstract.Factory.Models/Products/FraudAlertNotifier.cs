namespace Abstract.Factory.Models.Products
{
    public interface FraudAlertNotifier
    {
        string ChannelName { get; }
        void DispatchAlert(RegionTransaction tx, string decision);
    }
}