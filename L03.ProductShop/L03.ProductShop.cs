namespace L03.ProductShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductShop
    {
        public static void Main()
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, double>> shopsDatabase = new Dictionary<string, Dictionary<string, double>>();

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] informationAboutShop = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shopName = informationAboutShop[0];
                string productName = informationAboutShop[1];
                double priceOfProduct = double.Parse(informationAboutShop[2]);

                if (!shopsDatabase.ContainsKey(shopName))
                {
                    shopsDatabase[shopName] = new Dictionary<string, double>();
                }

                if (!shopsDatabase[shopName].ContainsKey(productName))
                {
                    shopsDatabase[shopName][productName] = priceOfProduct;
                }

                shopsDatabase[shopName][productName] = priceOfProduct;

            }

            foreach (var shopKVP in shopsDatabase.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shopKVP.Key}->");

                foreach (var productKVP in shopKVP.Value)
                {
                    Console.WriteLine($"Product: {productKVP.Key}, Price: {productKVP.Value}");
                }
            }
        }
    }
}
