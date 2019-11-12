using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.书上的实现
{
    class DecorWhip : CondimentDecorator
    {
        Beverage beverage;
        public DecorWhip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal Cost()
        {
            return 8 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", DecorWhip";
        }
    }
}
