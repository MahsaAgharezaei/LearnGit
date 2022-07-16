using System;
using System.Collections.Generic;
using System.Text;
using WiredBrainCoffeeShop.DataAccess.Models;



namespace WiredBrainCoffeeShop.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "frankfurt", BeansInStockingInKg = 107 };
            yield return new CoffeeShop { Location = "Munich", BeansInStockingInKg = 87 };
            yield return new CoffeeShop { Location = "frieburge", BeansInStockingInKg = 67 };
        }
    }
}