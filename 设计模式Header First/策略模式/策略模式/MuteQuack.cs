using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 呱呱叫
    /// </summary>
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("呱呱叫");
        }
    }
}
