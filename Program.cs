namespace Warehouse 
{
    class program
    {
        public static void Main(string[] args)
        {
            Warehouse highburyBranch = new Warehouse("Highbury");
            Warehouse ealingBranch = new Warehouse("Ealing");
            Warehouse camdenBranch = new Warehouse ("Camden");

            Item shirt = new Item("Vintage shirt");
            Item skirt = new Item("Mini skirt");
            Item jacket = new Item("Puffer jacket");

            highburyBranch.AddStock(shirt, 23);
            highburyBranch.AddStock(skirt, 12);
            highburyBranch.AddStock(jacket, 2);

            ealingBranch.AddStock(shirt, 12);
            ealingBranch.AddStock(skirt, 34);
            ealingBranch.AddStock(jacket, 18);

            camdenBranch.AddStock(shirt, 1);
            camdenBranch.AddStock(skirt, 3);
            camdenBranch.AddStock(jacket, 5);

            highburyBranch.PrintInventory();
            ealingBranch.PrintInventory();
            camdenBranch.PrintInventory();
        }

        
    }
}
