using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class SimpleDuck : Duck
    {
        public SimpleDuck()
        {
            this.QuackBeh = new SimpleQuack();
            this.FlyBeh = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("我是一只普通的鸭子");
        }
    }
}
