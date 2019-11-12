using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 橡皮鸭吱吱叫
    /// </summary>
    public class Squack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("吱吱叫");
        }
    }
}
