using Abstract.Factory.Models;
using Abstract.Factory.Models.Factories;

Console.WriteLine("=== [02] Abstract Factory ===\n");

Client fraudClient = new Client(new ThailandFraudFactory());
fraudClient.CreateSuite();
fraudClient.ProcessTransaction(new RegionTransaction("TX-TH-881", "TH", 65000m, false));

fraudClient.SetFactory(new EuropeFraudFactory());
fraudClient.ProcessTransaction(new RegionTransaction("TX-EU-402", "EU", 2500m, true));

fraudClient.SetFactory(new UsFraudFactory());
fraudClient.ProcessTransaction(new RegionTransaction("TX-US-905", "US", 15000m, false));

fraudClient.SetFactory(new JapanFraudFactory());
fraudClient.ProcessTransaction(new RegionTransaction("TX-JP-112", "JP", 500000m, true));