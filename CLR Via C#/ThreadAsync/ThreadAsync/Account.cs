using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAsync
{
    /// <summary>
    /// 账户类
    /// </summary>
    public class Account
    {
        public string Name { get; set; }
        private decimal Balance { get; set; }

        public Account(decimal initialBalance)
        {
            this.Balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>the amount that deposit</returns>
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>the amount that withdraw</returns>
        public decimal Withdraw(decimal amount)
        {
            if (Balance - amount < 0)
            {
                return -1;
            }
            Balance -= amount;
            return Balance;
        }
        private static readonly object lockObj = new object();
        public decimal WithdrawLock(decimal amount)
        {
            lock (lockObj)
            {
                if (Balance - amount < 0)
                {
                    return -1;
                }
                Balance -= amount;
            }
            return Balance;
        }
        public decimal DepositLock(decimal amount)
        {
            lock (lockObj)
            {
                Balance += amount;
            }
            return Balance;
        }

        public decimal WithdrawMonitor(decimal amount)
        {
            Monitor.Enter(lockObj);
            if (Balance - amount < 0)
            {
                Monitor.Wait(lockObj);
                Balance -= amount;
                Console.WriteLine("当前Balance  " + Balance);
                //Monitor.Pulse(lockObj);
            }
            Monitor.Exit(lockObj);
            return Balance;
        }
        public decimal DepositMonitor(decimal amount)
        {
            Monitor.Enter(lockObj);
            try
            {
                Balance += amount;
                Console.WriteLine("当前Balance  " + Balance);
                Monitor.Pulse(lockObj);
            }
            finally
            {
                Monitor.Exit(lockObj);
            }
            return Balance;
        }

        public decimal DepositInterlocked(decimal amount)
        {
            int x = (int)Balance;
            return Balance = Interlocked.Add(ref x, (int)amount);
        }
        public decimal WithdrawInterlocked(decimal amount)
        {
            int x = (int)Balance;
            return Balance = Interlocked.Add(ref x, -(int)amount);
        }
    }
}
