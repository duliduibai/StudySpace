using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAsync
{
    /// <summary>
    /// 测试Lock来同步线程
    /// </summary>
    public class TreadAsyncTest
    {
        int taskNum = 0;
        public TreadAsyncTest(int taskNum)
        {
            this.taskNum = taskNum;
        }
        public void Test(Func<decimal> func, OperType type, Func<decimal> func_deposit = null)
        {
            Console.WriteLine(type.ToString());
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<Task<decimal>> tasks = new List<Task<decimal>>();
            for (int i = 0; i < taskNum; i++)
            {
                tasks.Add(Task.Run<decimal>(func));
            }
            if (func_deposit != null)
            {
                for (int i = 0; i < taskNum; i++)
                {
                    tasks.Add(Task.Run<decimal>(func_deposit));
                }
            }
            var result = Task.WhenAll(tasks);
            OutputResult(result.Result);

            stopwatch.Stop();
            Console.WriteLine("cost time: " + stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine();
        }

        private void OutputResult(decimal[] result)
        {
            foreach (var item in result)
            {
                Console.WriteLine("余额： " + item);
            }
        }
    }

    public enum OperType
    {
        Withdraw = 0,
        WithdrawLock = 1,
        Deposit = 2,
        DepositLock = 3,
        MixOper = 4,
        MixOperLock = 5,
        WithdrawMonitor = 6,
        DepositMonitor = 7
    }
}
