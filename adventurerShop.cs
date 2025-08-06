public class adventurerShop
{
    public static void Main()
    {
        Dictionary<string, float> priceList = new Dictionary<string, float>
        {
            {"Rope", 10},
            {"Torches", 15},
            {"Climbing Equipment", 25},
            {"Clean Water", 1},
            {"Machete", 20},
            {"Canoe", 200},
            {"Food Supplies", 1}
        };

        int selection;
        string product;
        int discountFactor = 1;
        string name;



        void checkName()
        {
            do
            {
                Console.WriteLine("Identify yourself!");
                name = Console.ReadLine();
                if (name == "Suhaib")
                {   discountFactor = 2;
                    Console.WriteLine("Ah, my friend, you have returned!\nLet me get you a discount! 50% off from all items!\n Browse to your hearts content!");
                };
            }
            while (string.IsNullOrEmpty(name));
        };

        void checkPrice()
        {

            Console.Write(@"The following items are available:
            1 - Rope
            2 - Torches
            3 - Climbing Equipment
            4 - Clean Water
            5 - Machete
            6 - Canoe
            7 - Food Supplies
            What number do you want to see the price of? ");

            do
            {
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection > 7 || selection < 1)
                    Console.WriteLine("Invalid Product Number! Select a number between 1~7!");
            }
            while (selection > 7 || selection < 1);

            product = selection switch
            {
                1 => $"Ropes cost {priceList["Rope"] / discountFactor} gold.",
                2 => $"Torches cost {priceList["Torches"] / discountFactor} gold.",
                3 => $"Climbing Equipment costs {priceList["Climbing Equipment"] / discountFactor} gold.",
                4 => $"Clean Water cost {priceList["Clean Water"] / discountFactor} gold.",
                5 => $"Machete cost {priceList["Machete"] / discountFactor} gold.",
                6 => $"Canoe cost {priceList["Canoe"] / discountFactor} gold.",
                7 => $"Food Supplies cost {priceList["Food Supplies"] / discountFactor} gold."

            };
        };

        checkName();
        checkPrice();
        Console.WriteLine(product);
    }
}