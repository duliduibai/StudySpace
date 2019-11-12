using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    internal class DrinkHouseBlend : Drink
    {
        private string Name;
        public DrinkHouseBlend(string name) : this(name, 15)
        {
        }

        public DrinkHouseBlend(string name, decimal basicPrice) : base(basicPrice)
        {
            this.Name = name;
            lstSeason.Add(new Seasoning { Name = "牛奶", Amount = 1, Comment = "加1份牛奶", Price = 3 });
            lstSeason.Add(new Seasoning { Name = "巧克力", Amount = 1, Comment = "加1份巧克力", Price = 8 });
        }
        public override void PrintDescription()
        {
            string comment = "";
            lstSeason.ForEach(m => comment += m.Comment);
            Console.WriteLine($"这是一杯{Name}, 里面加了{comment},价格是{Cost()}");
        }
    }
}
