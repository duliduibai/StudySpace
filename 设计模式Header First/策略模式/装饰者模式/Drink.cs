using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    public abstract class Drink
    {
        public List<Seasoning> lstSeason = new List<Seasoning>();
        public decimal BasicPrice { get; set; }
        public Drink(decimal price)
        {
            this.BasicPrice = price;
        }
        public decimal Cost()
        {
            decimal price = BasicPrice;
            lstSeason.ForEach(m => price += (m.Price * (decimal)m.Amount));
            return price;
        }
        public abstract void PrintDescription();
    }
}
