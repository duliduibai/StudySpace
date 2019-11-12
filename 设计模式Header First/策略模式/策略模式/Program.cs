using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new SimpleDuck();
            duck.Display();
            duck.Fly();
            duck.Quack();
            duck = new RubberDuck();
            duck.Display();
            duck.Fly();
            duck.Quack();

            Console.ReadLine();
        }
    }
}
