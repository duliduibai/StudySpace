using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAsync
{
    public class AutoResetEventTest
    {
        private readonly int MaxNum = 100;
        private readonly int NumThreads = 5;
        private AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        private AutoResetEvent autoResetEvent_2 = new AutoResetEvent(false);
        /// <summary>
        /// 两个线程交替打印奇数偶数，形成0,1,2,3,4,5这样的输出
        /// </summary>
        public void WriteEvenOddByTwoThreads()
        {
            Thread t1 = new Thread(WriteEven);
            Thread t2 = new Thread(WriteOdd);
            t1.Name = "1";
            t2.Name = "2";
            t1.Start();
            t2.Start();
        }
        /// <summary>
        /// 打印偶数
        /// </summary>
        private void WriteEven()
        {
            for (int i = 0; i < MaxNum; i += 2)
            {
                autoResetEvent.WaitOne();
                Console.WriteLine("线程" + Thread.CurrentThread.Name + ": " + i);
                autoResetEvent_2.Set();
            }
        }

        /// <summary>
        /// 打印偶数
        /// </summary>
        private void WriteOdd()
        {
            for (int i = 1; i < MaxNum; i += 2)
            {
                autoResetEvent.Set();
                autoResetEvent_2.WaitOne();
                Console.WriteLine("线程" + Thread.CurrentThread.Name + ": " + i);
            }
        }

        public void WriteEvenOddWithMultyTreads()
        {
            List<AutoResetEvent> events = new List<AutoResetEvent>();
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < NumThreads; i++)
            {
                events.Add(new AutoResetEvent(false));
                var t = new Thread((num) =>
                {
                    int x = (int)num;
                    for (int j = x; j < MaxNum; j += NumThreads)
                    {
                        if (x + 1 == NumThreads)
                        {
                            events[0].Set();
                        }
                        events[x].WaitOne();
                        Console.WriteLine("线程" + Thread.CurrentThread.Name + ": " + j);
                        if (x + 1 != NumThreads)
                        {
                            events[x + 1].Set();
                        }
                    }
                });
                t.Name = i.ToString();
                threads.Add(t);
            }
            for (int i = 0; i < threads.Count; i++)
            {
                threads[i].Start(i);
            }
        }

        public async void WriteEvenOddWithMultyTasks()
        {
            TaskFactory taskFactory = new TaskFactory();
            List<Task> tasks = new List<Task>();
            List<AutoResetEvent> events = new List<AutoResetEvent>();
            for (int i = 0; i < NumThreads; i++)
            {
                events.Add(new AutoResetEvent(false));
                #region  数组溢出
                //tasks.Add(Task.Run(() =>
                //{
                //    for (int j = i; j < MaxNum; j += NumThreads)
                //    {
                //        if (i + 1 == NumThreads)
                //        {
                //            events[0].Set();
                //        }
                //        events[i].WaitOne();
                //        Console.WriteLine("线程" + Thread.CurrentThread.Name + ": " + j);
                //        if (i + 1 != NumThreads)
                //        {
                //            events[i + 1].Set();
                //        }
                //    }
                //}));
                #endregion
                ///OK_1
                //tasks.Add(new Task((temp) =>
                //{
                //    int x = (int)temp;
                //    for (int j = x; j < MaxNum; j += NumThreads)
                //    {
                //        if (x + 1 == NumThreads)
                //        {
                //            events[0].Set();
                //        }
                //        events[x].WaitOne();
                //        Console.WriteLine("线程" + Thread.CurrentThread.ManagedThreadId + ": " + j);
                //        if (x + 1 != NumThreads)
                //        {
                //            events[x + 1].Set();
                //        }
                //    }
                //}, i));
                ///OK_2
                tasks.Add(taskFactory.StartNew(temp => {
                    int x = (int)temp;
                    for (int j = x; j < MaxNum; j += NumThreads)
                    {
                        if (x + 1 == NumThreads)
                        {
                            events[0].Set();
                        }
                        events[x].WaitOne();
                        Console.WriteLine("线程" + Thread.CurrentThread.ManagedThreadId + ": " + j);
                        if (x + 1 != NumThreads)
                        {
                            events[x + 1].Set();
                        }
                    }
                }, i));
            }
            ///OK_1
            //foreach (var item in tasks)
            //{
            //    item.Start();
            //}
            await Task.WhenAll(tasks.ToArray());
        }

        /// <summary>
        /// 当调用WaitOne()的时候，会检查该semaphore是否存在剩余的资源（即计数器是否为0）：
        /// 1. 如果此时计数器为0，则该线程会阻塞在当前状态，直到调用对应的Release方法将计数器加1，提供资源
        /// 2. 如果此时计数器大于0，则会消耗一次资源，即计数器减1；线程会继续执行下去。
        /// 通常在使用信号量时，希望访问共享资源的线程将尝试获取一个许可证
        /// ，如果信号量的计数器大于0，线程将获取一个许可证并将信号量的计数器减1
        /// ，否则先线程将阻塞，直到获取一个许可证；
        ///         当线程不再需要共享资源时，将释放锁拥有的许可证，并将许可证的数量加1
        /// ，如果有其他的线程正在等待许可证，那么该线程将立刻获取许可证。
        /// </summary>
        public void WriteEvenOddWithSemaphore()
        {
            int index = 0;
            List<Semaphore> semaphores = new List<Semaphore>();
            for (int i = 0; i < NumThreads; i++)
            {
                semaphores.Add(new Semaphore(1, 1));
                if (i != NumThreads - 1)
                {
                    semaphores[i].WaitOne();
                }
            }
            for (int i = 0; i < NumThreads; i++)
            {
                new Thread((temp) =>
                {
                    var x = Convert.ToInt32(temp);
                    var preSemaphore = x == 0 ? semaphores[semaphores.Count - 1] : semaphores[x - 1];
                    var currSemaphore = semaphores[x];
                    while (true)
                    {
                        preSemaphore.WaitOne();
                        Interlocked.Increment(ref index);
                        if (index > MaxNum)
                        {
                            return;
                        }
                        Console.WriteLine(Thread.CurrentThread.Name + ": " + index);
                        currSemaphore.Release();
                    }
                })
                { Name = $"线程{i}" }.Start(i);
            }
        }
    }
}
