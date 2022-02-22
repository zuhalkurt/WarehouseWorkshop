using System;
using System.Collections.Generic;

namespace Warehouse
{
    public class Warehouse
    {
        public string Name { get; set;}
        
        public List<Stock> Stock { get; set; }

        public Warehouse(string name)
        {
            Stock = new List<Stock>();
            Name = name;
            
        }
        
        public void AddStock(Item item, int stockAmount)
        {
            Stock.Add(new Stock(item, stockAmount));
        }

        public void PrintInventory()
        {
            Console.WriteLine("Inventory of warehouse: ");

            foreach(Stock stockItem in Stock)
            {
                Console.WriteLine($"   {stockItem.Item.Name}: {stockItem.Amount}");
            }
        }
    }
}