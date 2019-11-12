using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAsync
{
    public class ParallelTest
    {
        public void Test()
        {
            int a = 0;
            System.Threading.Tasks.Parallel.For(0, 100000, (i) =>
            {
                a++;
            });
            Console.WriteLine(a);
        }
        public void TestInterlocked()
        {
            int a = 0;
            System.Threading.Tasks.Parallel.For(0, 100000, (i) =>
            {
                Interlocked.Increment(ref a);
            });
            Console.WriteLine(a);
        }
    }
}
