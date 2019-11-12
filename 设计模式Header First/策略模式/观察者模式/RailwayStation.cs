using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class RailwayStation : IObserver
    {
        public void RecevieData()
        {
            Console.WriteLine("各位乘客,今天最新的报纸到了,如有需要请到服务台领取");
        }
    }
}
