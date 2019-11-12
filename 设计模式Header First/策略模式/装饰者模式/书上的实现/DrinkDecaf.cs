using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.书上的实现
{
    class DrinkDecaf : Beverage
    {
        public DrinkDecaf()
        {
            description = "脱因咖啡";
        }
        public override decimal Cost()
        {
            return 18;
        }
    }
}
