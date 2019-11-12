using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBeh { get; set; }
        public IQuackBehavior QuackBeh { get; set; }
        public void Fly()
        {
            FlyBeh.Fly();
        }
        public void Quack()
        {
            QuackBeh.Quack();
        }

        public abstract void Display();
    }
}
