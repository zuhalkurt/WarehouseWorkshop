namespace Warehouse
{
    public class Stock
    {
        public Item Item { get; set; }

        public int Amount { get; set;}

        public Stock(Item item, int amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}