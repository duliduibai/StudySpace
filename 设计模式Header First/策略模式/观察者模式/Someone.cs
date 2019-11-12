using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Someone : IObserver
    {
        public void RecevieData()
        {
            Console.WriteLine("最新的报纸到了,看看今天发生了什么");
        }
    }
}
