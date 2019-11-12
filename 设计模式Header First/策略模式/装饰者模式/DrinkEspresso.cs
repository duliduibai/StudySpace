using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    public class DrinkEspresso : Drink
    {
        private string Name;
        public DrinkEspresso(string name) : this(name, 10)
        {
        }

        public DrinkEspresso(string name, decimal basicPrice) : base(basicPrice)
        {
            this.Name = name;
            lstSeason.Add(new Seasoning { Name = "西米露", Amount = 1, Comment = "加1份西米露", Price = 3 });
            lstSeason.Add(new Seasoning { Name = "芒果", Amount = 1, Comment = "加1份芒果", Price = 2 });
        }
        public override void PrintDescription()
        {
            string comment = "";
            lstSeason.ForEach(m => comment += m.Comment + ",");
            Console.WriteLine($"这是一杯{Name}, {comment.TrimEnd(',')},价格是{Cost()}");
        }
    }
}
