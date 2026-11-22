using Factory.Method.Models;
using Factory.Method.Models.Creators;

Console.WriteLine("=== [01] Factory Method: AI Fraud Ingestion ===\n");

var cardTx = new TransactionData("TX-9001", "4532112233448899", 45000m);
FraudGateway cardGateway = new CreditCardFraudGateway();
cardGateway.ProcessTransaction(cardTx);

var transferTx = new TransactionData("TX-9002", "0981234567", 150000m);
FraudGateway transferGateway = new BankTransferFraudGateway();
transferGateway.ProcessTransaction(transferTx);

var cryptoTx = new TransactionData("TX-9003", "0x71c82154a227d2d593b2325b4776acceae3b976f", 850000m);
FraudGateway cryptoGateway = new CryptoFraudGateway();
cryptoGateway.ProcessTransaction(cryptoTx);