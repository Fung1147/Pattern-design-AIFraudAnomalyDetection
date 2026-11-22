namespace Factory.Method.Models.Products
{
    public interface TransactionExtractor
    {
        string ChannelType { get; }
        void ParseData(TransactionData data);
        void MaskPii(TransactionData data);
        void ExtractFeatures(TransactionData data);
    }
}