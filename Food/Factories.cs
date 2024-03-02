using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Food.Concretes;

namespace Food
{
    public class Factories
    {

        public class PizzaFactory : FactoryOrder
        {
            public override OrderFood CreateOrder()
            {
                return new Pizza();
            }
        }

        public class HamburgerFactory : FactoryOrder
        {
            public override OrderFood CreateOrder()
            {
                return new Hamburger();
            }
        }

        public class HotDogFactory : FactoryOrder
        {
            public override OrderFood CreateOrder()
            {
                return new HotDog();
            }
        }

        public abstract class ServeFactory
        {

            public abstract PackageOrder ServeOrder();

        }

        public class ToGoFactory : ServeFactory
        {
            public override PackageOrder ServeOrder()
            {
                return new ToGo();
            }
        }

        public class ToEatHereFactory : ServeFactory
        {
            public override PackageOrder ServeOrder()
            {
                return new ToEatHere();
            }
        }

    }
}
