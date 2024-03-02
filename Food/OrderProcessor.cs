using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public class OrderProcessor
    {
        private readonly UserInputHandler _inputHandler;
        private readonly FoodFactorySelector _foodFactorySelector;
        private readonly PackageOrderFactorySelector _packageOrderFactorySelector;

        public OrderProcessor()
        {
            _inputHandler = new UserInputHandler();
            _foodFactorySelector = new FoodFactorySelector();
            _packageOrderFactorySelector = new PackageOrderFactorySelector();
        }

        public void ProcessOrder()
        {
            var selectedFood = _inputHandler.GetSelectedFood();
            var ingredients = _inputHandler.GetIngredients();
            var foodFactory = _foodFactorySelector.SelectFactory(selectedFood);
            var order = foodFactory?.CreateOrder();

            if (order != null)
            {
                order.CreateOrder(ingredients);
                var selectedPackageOption = _inputHandler.GetPackageOption();
                var packageOrderFactory = _packageOrderFactorySelector.SelectFactory(selectedPackageOption);
                var packageOrder = packageOrderFactory?.ServeOrder();

                packageOrder?.ServeOrder();
            }

        }


    }
}
