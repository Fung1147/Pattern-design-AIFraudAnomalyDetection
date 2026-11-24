using System;
using Builder.Models.Builders;
using Builder.Models.Directors;
using Builder.Models.Products;

Console.WriteLine("=== [03] Builder Pattern: AI Fraud Detection Pipeline Builder ===\n");

FraudDirector director = new FraudDirector();

// สร้างโมเดลจับทุจริตธุรกรรม + Lightweight
TransactionFraudBuilder txBuilder = new TransactionFraudBuilder();
director.ConstructLightweightModel(txBuilder, "AI-TX-EDGE-01");
TransactionFraud txModel = txBuilder.GetResult();
txModel.DisplaySpecifications();

// สร้างโมเดลจับแฮกบัญชี + Standard
AccountTakeoverBuilder atoBuilder = new AccountTakeoverBuilder();
director.ConstructStandardModel(atoBuilder, "AI-ATO-CLOUD-02");
AccountTakeover atoModel = atoBuilder.GetResult();
atoModel.DisplaySpecifications();

// สร้างโมเดลจับฟอกเงิน + Deep AI
MoneyLaunderingBuilder amlBuilder = new MoneyLaunderingBuilder();
director.ConstructEnterpriseModel(amlBuilder, "AI-AML-ENT-03");
MoneyLaundering amlModel = amlBuilder.GetResult();
amlModel.DisplaySpecifications();

// test Rest()
director.ConstructLightweightModel(amlBuilder, "AI-AML-EDGE-04");
MoneyLaundering fastAmlModel = amlBuilder.GetResult();
fastAmlModel.DisplaySpecifications();