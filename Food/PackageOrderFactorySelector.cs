using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Food.Factories;

namespace Food
{
    public class PackageOrderFactorySelector
    {
        public ServeFactory SelectFactory(string selectedPackageOption)
        {
            return selectedPackageOption switch
            {
                "1" => new ToGoFactory(),
                "2" => new ToEatHereFactory(),
                _ => null,
            };
        }
    }
}
