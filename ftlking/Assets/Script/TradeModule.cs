namespace Script
{
    public class TradeModule : EventModule
    {
        public Character Trader { get; set; }
        public Item ItemToSell { get; set; }
        public JSONDataCollector Collector { get; set; }
        
        public TradeModule()
        {
            Trader = new Character();
            ItemToSell = new Item();
            Collector = new JSONDataCollector();
            
            ItemTables t = Collector.GetItemTables(Collector.ItemTablesJsonName);
            
            t.AllItems[UnityEngine.Random.Range(0, t.AllItems.Count)].Dump();
            
            //TODO Finir le systeme de trading avec achat de l'item to sell etc.
        }
    }
}