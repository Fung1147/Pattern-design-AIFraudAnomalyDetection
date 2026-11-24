namespace Builder.Models.Products
{
    public class MoneyLaundering : FraudDetectionModel
    {
        public int GraphTraversalHops { get; set; }
        public string RegulatoryRuleSet { get; set; } = string.Empty;

        public override void DisplaySpecifications()
        {
            base.DisplaySpecifications();
            Console.WriteLine($"[AML Specific] Money Trail Hops   : {GraphTraversalHops} hops");
            Console.WriteLine($"[AML Specific] Compliance Ruleset : {RegulatoryRuleSet}");
            Console.WriteLine($"==================================================\n");
        }
    }
}