using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class School : IObserver
    {
        public void RecevieData()
        {
            Console.WriteLine("教务处,我们收到最新的报纸了,你们分发到各个班级");
        }
    }
}
