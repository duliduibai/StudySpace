using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    internal class DrinkDarkRoast : Drink
    {
        private string Name;
        public DrinkDarkRoast(string name) : this(name, 20)
        {
        }

        public DrinkDarkRoast(string name, decimal basicPrice) : base(basicPrice)
        {
            this.Name = name;
            lstSeason.Add(new Seasoning { Name = "摩卡", Amount = 1, Comment = "加1份摩卡", Price = 5 });
            lstSeason.Add(new Seasoning { Name = "奶泡", Amount = 1, Comment = "加1份奶泡", Price = 2 });
        }

        public override void PrintDescription()
        {
            string comment = "";
            lstSeason.ForEach(m => comment += m.Comment + ",");
            Console.WriteLine($"这是一杯{Name}, {comment.TrimEnd(',')},价格是{Cost()}");
        }
    }
}
