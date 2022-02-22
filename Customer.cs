namespace Warehouse
{
    public class Customer
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Customer(string name , int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}