using Factory.Method.Models;
using Factory.Method.Models.Creators;

Console.WriteLine("=== Factory Method ===\n");

var cardTx = new TransactionData("TX-9001", "4532112233448899", 45000m);
FraudGateway cardGateway = new CreditCardGateway();
cardGateway.ProcessTransaction(cardTx);

var transferTx = new TransactionData("TX-9002", "0981234567", 150000m);
FraudGateway transferGateway = new BankTransferGateway();
transferGateway.ProcessTransaction(transferTx);

var cryptoTx = new TransactionData("TX-9003", "0x71c82154a227d2d593b2325b4776acceae3b976f", 850000m);
FraudGateway cryptoGateway = new CryptoGateway();
cryptoGateway.ProcessTransaction(cryptoTx);

Console.WriteLine("-------------------------------------------------------------");

var incomingTransactions = new List<(FraudGateway Gateway, TransactionData Data)>
{
    (new CreditCardGateway(), new TransactionData("TX-9001", "4532112233448899", 45000m)),
    (new BankTransferGateway(), new TransactionData("TX-9002", "0981234567", 150000m)),
    (new CryptoGateway(), new TransactionData("TX-9003", "0x71c82154a227d2d593b2325b4776acceae3b976f", 850000m))
};

foreach (var (gateway, txData) in incomingTransactions)
{
    gateway.ProcessTransaction(txData);
}