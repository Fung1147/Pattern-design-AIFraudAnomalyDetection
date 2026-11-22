namespace Factory.Method.Models.Products
{
    public class BankTransferExtractor : TransactionExtractor
    {
        public string ChannelType => "INTERBANK_TRANSFER";
        private readonly string _regulation = "BOT-PDPA";

        public void ParseData(TransactionData data)
            => Console.WriteLine($"[{ChannelType}] อ่านข้อมูลโอนเงินรายการ {data.TransactionId} ยอด {data.Amount:N2} บาท");

        public void MaskPii(TransactionData data)
        {
            data.AccountId = "XXX-X-XX" + data.AccountId[^3..];
            Console.WriteLine($"[{ChannelType}] ปิดบังเลขบัญชีตามกฎ {_regulation} -> {data.AccountId}");
        }

        public void ExtractFeatures(TransactionData data)
        {
            data.AiFeatures["is_night_transfer"] = 1.0;
            data.AiFeatures["new_recipient_flag"] = 1.0;
            Console.WriteLine($"[{ChannelType}] สกัด Feature สำเร็จ: {data.AiFeatures.Count} ตัวแปร");
        }
    }
}