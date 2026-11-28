namespace Factory.Method.Models.Products
{
    public class CreditCardExtractor : TransactionExtractor
    {
        public string ChannelType {get;} = "CREDIT_CARD";
        private string _standard = "PCI-DSS v4.0";

        public void ParseData(TransactionData data)
            => Console.WriteLine($"[{ChannelType}] แกะข้อมูล ISO-8583 รายการ {data.TransactionId} ยอด {data.Amount:N2} บาท");

        public void MaskPii(TransactionData data)
        {
            data.AccountId = "XXXX-XXXX-XXXX-" + data.AccountId[^4..];
            Console.WriteLine($"[{ChannelType}] ปิดบังเลขบัตรตามมาตรฐาน {_standard} -> {data.AccountId}");
        }

        public void ExtractFeatures(TransactionData data)
        {
            data.AiFeatures["amount_ratio"] = (double)(data.Amount / 10000m);
            data.AiFeatures["velocity_1h"] = 3.0;
            Console.WriteLine($"[{ChannelType}] สกัด Feature สำเร็จ: {data.AiFeatures.Count} ตัวแปร");
        }
    }
}