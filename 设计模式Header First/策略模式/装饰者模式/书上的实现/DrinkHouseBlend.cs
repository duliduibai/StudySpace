using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.书上的实现
{
    class DrinkHouseBlend : Beverage
    {
        public DrinkHouseBlend()
        {
            description = "Drink House Blend";
        }
        public override decimal Cost()
        {
            return 12;
        }
    }
}
