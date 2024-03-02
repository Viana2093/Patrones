using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public class Concretes
    {
        public class Pizza : OrderFood
        {
            public override void CreateOrder(List<string> Ingredients)
            {
                Console.WriteLine("Creando Orden de Pizza...");

                foreach (var item in Ingredients)
                {
                    Console.WriteLine("Se agrego: " + item + " a tu pizza.");
                }
            }
        }

        public class Hamburger : OrderFood
        {
            public override void CreateOrder(List<string> Ingredients)
            {
                Console.WriteLine("Creando Orden de Hamburguesa...");

                foreach (var item in Ingredients)
                {
                    Console.WriteLine("Se agrego: " + item + " a tu Hamburguesa.");
                }
            }
        }

        public class HotDog : OrderFood
        {
            public override void CreateOrder(List<string> Ingredients)
            {
                Console.WriteLine("Creando Orden de HotDog...");

                foreach (var item in Ingredients)
                {
                    Console.WriteLine("Se agrego: " + item + " a tu hotdog.");
                }
            }
        }

        public class ToGo : PackageOrder
        {
            public override void ServeOrder()
            {
                Console.WriteLine("Order Empacada para llevar.");
            }
        }

        public class ToEatHere : PackageOrder
        {
            public override void ServeOrder()
            {
                Console.WriteLine("Order Empacada para comer en el lugar.");
            }
        }
    }
}