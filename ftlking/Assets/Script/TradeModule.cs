namespace Script
{
    public class TradeModule : EventModule
    {   
        public TradeModule()
        {
        }

        public void TradeAnItem(Character Buyer, Item ItemToSell)
        {
            Buyer.CoinsMoney.Coins -= ItemToSell.Price.Coins;
            Buyer.Inv.Invent.Add(ItemToSell);
        }
    }
}