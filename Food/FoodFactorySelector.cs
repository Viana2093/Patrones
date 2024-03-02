using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Food.Factories;

namespace Food
{
    public class FoodFactorySelector
    {
        public FactoryOrder SelectFactory(string selectedFood)
        {
            return selectedFood switch
            {
                "1" => new PizzaFactory(),
                "2" => new HamburgerFactory(),
                "3" => new HotDogFactory(),
                _ => null,
            };
        }

    }
}
