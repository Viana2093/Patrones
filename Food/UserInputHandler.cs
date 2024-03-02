using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public class UserInputHandler
    {
        public string GetSelectedFood()
        {
            string selectedFood;
            do
            {
                Console.WriteLine("Hola, ¿qué deseas comer hoy?");
                Console.WriteLine("1. Pizza");
                Console.WriteLine("2. Hamburguesa");
                Console.WriteLine("3. HotDog");
                Console.Write("Ingrese el número de su elección: ");
                selectedFood = Console.ReadLine() ?? "";
            } while (string.IsNullOrEmpty(selectedFood) || (selectedFood != "1" && selectedFood != "2" && selectedFood != "3"));
            return selectedFood;

        }

        public List<string> GetIngredients()
        {

            var ingredients = new List<string>();
            Console.WriteLine("Puedes agregar hasta 3 ingredientes especiales a su orden:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingresa el Ingrediente Nro. {i + 1}: ");
                var ingredient = Console.ReadLine() ?? "";
                if (!string.IsNullOrEmpty(ingredient))
                {
                    ingredients.Add(ingredient);
                }
            }
            return ingredients;

        }

        public string GetPackageOption()
        {
            string selectedPackageOption;
            do
            {
                Console.WriteLine("¿Deseas la orden para llevar o para comer en el lugar?");
                Console.WriteLine("1. Para llevar");
                Console.WriteLine("2. Para comer en el lugar");
                Console.Write("Ingrese el número de su elección: ");
                selectedPackageOption = Console.ReadLine() ?? "";
            } while (string.IsNullOrEmpty(selectedPackageOption) || (selectedPackageOption != "1" && selectedPackageOption != "2"));
            return selectedPackageOption;

        }

    }
}
