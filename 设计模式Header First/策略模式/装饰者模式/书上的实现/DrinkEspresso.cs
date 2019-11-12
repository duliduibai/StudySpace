using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.书上的实现
{
    /// <summary>
    /// 浓缩咖啡
    /// </summary>
    class DrinkEspresso : Beverage
    {
        public DrinkEspresso()
        {
            description = "浓缩咖啡";
        }
        public override decimal Cost()
        {
            return 10;
        }
    }
}
