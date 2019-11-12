using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.FlyBeh = new FlyNoWay();
            this.QuackBeh = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("我是一只橡皮鸭");
        }
    }
}
