using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopNum = 1;
            //TestLock();
            for (int i = 0; i < loopNum; i++)
            {
                //TestLock();
                //TestMonitor();
                //TestInterlocked();
            }

            AutoResetEventTest autoResetEventTest = new AutoResetEventTest();
            //autoResetEventTest.WriteEvenOddByTwoThreads();
            //autoResetEventTest.WriteEvenOddWithMultyTreads();
            //autoResetEventTest.WriteEvenOddWithMultyTasks();
            autoResetEventTest.WriteEvenOddWithSemaphore();
            //TestMonitor();
            Console.ReadLine();
        }

        /// <summary>
        /// Lock可以说是monitor的简单实现
        /// </summary>
        private static void TestLock()
        {
            Account account;
            TreadAsyncTest test = new TreadAsyncTest(50);
            account = new Account(10);
            test.Test(() => account.Withdraw(10), OperType.Withdraw);
            account = new Account(10);
            test.Test(() => account.WithdrawLock(10), OperType.WithdrawLock);
            account = new Account(0);
            test.Test(() => account.Deposit(10), OperType.Deposit);
            account = new Account(0);
            test.Test(() => account.DepositLock(10), OperType.DepositLock);
        }
        /// <summary>
        /// 使用Monitor.Enter()和Monitor.Exit()来获取和释放对象锁
        /// 并且一般将Exit方法放到try-catch-finally块中
        /// </summary>
        private static void TestMonitor()
        {
            Account account;
            TreadAsyncTest test = new TreadAsyncTest(20);
            //account = new Account(10);
            //test.Test(() => account.Withdraw(10), OperType.Withdraw);
            account = new Account(0);
            test.Test(() => account.WithdrawMonitor(10), OperType.WithdrawMonitor, ()=>account.DepositMonitor(10));
            Console.WriteLine(account.GetBalance());
            //account = new Account(0);
            //test.Test(() => account.Deposit(10), OperType.Deposit);
            //account = new Account(0);
            //test.Test(() => account.DepositMonitor(10), OperType.DepositMonitor);
        }
        private static void TestInterlocked()
        {
            Account account;
            TreadAsyncTest test = new TreadAsyncTest(20);
            account = new Account(0);
            test.Test(() => account.WithdrawInterlocked(10), OperType.Deposit);
            Console.WriteLine(account.GetBalance());
            account = new Account(0);
            test.Test(() => account.DepositInterlocked(10), OperType.DepositMonitor);
            Console.WriteLine(account.GetBalance());
        }

    }
}
