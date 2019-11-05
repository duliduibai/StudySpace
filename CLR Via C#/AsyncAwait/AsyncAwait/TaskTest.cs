using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class TaskTest
    {
        string[] strArr = new string[] { "111", "222", "333" };
        string[] strFile = new string[] { "111.txt", "222.txt", "333.txt" };
        string[] strFileParallel = new string[] { "111para.txt", "222para.txt", "333para.txt" };
        string[] strFileThreadPool = new string[] { "111tpool.txt", "222tpool.txt", "333tpool.txt" };
        string[] strFileThread = new string[] { "111thread.txt", "222thread.txt", "333thread.txt" };
        static AutoResetEvent AutoResetEvent = new AutoResetEvent(false);
        public void TestTaskArray()
        {
            Console.WriteLine("TestTaskArray");
            Task<string>[] tasks = new Task<string>[]
            {
                Task.Run(()=>Console_1(strArr[0]))
                ,Task.Run(()=>Console_2(strArr[1]))
                ,Task.Run(()=>Console_3(strArr[2]))
            };
            var result = Task.WhenAll(tasks);
            foreach (var item in result.Result)
            {
                Console.WriteLine("返回结果： " + item);
            }
        }

        public async void TestTaskAsync()
        {
            Console.WriteLine("TestTaskAsync");
            Task<string>[] tasks = new Task<string>[]
            {
                Task.Run(()=>Console_1(strArr[0]))
                ,Task.Run(()=>Console_2(strArr[1]))
                ,Task.Run(()=>Console_3(strArr[2]))
            };
            var result = await Task.WhenAll(tasks);
            foreach (var item in result)
            {
                Console.WriteLine("返回结果： " + item);
            }
        }

        /// <summary>
        /// Executes each of the provided actions, possibly in parallel.
        /// 可能并行工作，估计在小的循环中没什么作用，至少这个方法没什么用
        /// 129ms
        /// </summary>
        public void ParallelTest()
        {
            Console.WriteLine("ParallelTest");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.Invoke(
                ()=> WriteToFileSync_1(strFileParallel[0], strArr[0])
                , () => WriteToFileSync_1(strFileParallel[1], strArr[1])
                , () => WriteToFileSync_1(strFileParallel[2], strArr[2]));
            stopwatch.Stop();
            Console.WriteLine($"ParallelTest cost time: {stopwatch.Elapsed.TotalMilliseconds}");
        }

        /// <summary>
        /// ThreadPool，都是后台线程，需要使用类似于AutoResetEvent 的方式来捕获线程的状态
        /// </summary>
        public void ThreadPoolTest()
        {
            Console.WriteLine("ThreadPoolTest");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ThreadPool.QueueUserWorkItem((obj) => WriteToFileSync_1(strFileThreadPool[0], strArr[0]));
            ThreadPool.QueueUserWorkItem((obj) => WriteToFileSync_1(strFileThreadPool[1], strArr[1]));
            ThreadPool.QueueUserWorkItem((obj) => WriteToFileSync_1(strFileThreadPool[2], strArr[2]));
            ///大概是说接收到一个信号就释放
            AutoResetEvent.WaitOne();
            stopwatch.Stop();
            Console.WriteLine($"ThreadPoolTest cost time: {stopwatch.Elapsed.TotalMilliseconds}");
        }

        /// <summary>
        /// 90-160ms
        /// </summary>
        public void MultyThreadTest()
        {
            Console.WriteLine("MultyThreadTest");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<Thread> threads = new List<Thread>()
            {
                new Thread(()=>WriteToFileSync_1(strFileThread[0], strArr[0]))
                ,new Thread(()=>WriteToFileSync_1(strFileThread[1], strArr[1]))
                ,new Thread(()=>WriteToFileSync_1(strFileThread[2], strArr[2]))
            };
            threads.ForEach(m=>m.Start());
            threads[0].Join();
            threads[1].Join();
            threads[2].Join();
            stopwatch.Stop();
            Console.WriteLine($"MultyThreadTest cost time: {stopwatch.Elapsed.TotalMilliseconds}");
        }


        /// <summary>
        /// 15-30ms
        /// </summary>
        public void TestArraySubAsync()
        {
            Console.WriteLine("TestArraySubAsync");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<string>[] tasks = new Task<string>[]
            {
                WriteToFileAsync_1(strFile[0], strArr[0])
                ,WriteToFileAsync_1(strFile[1], strArr[1])
                ,WriteToFileAsync_1(strFile[2], strArr[2])
            };
            var result = Task.WhenAll(tasks);
            stopwatch.Stop();
            Console.WriteLine($"TestArraySubAsync cost time: {stopwatch.Elapsed.TotalMilliseconds}");
        }

        /// <summary>
        /// 150-200ms
        /// </summary>
        public void TestArraySync()
        {
            Console.WriteLine("TestArraySync");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            WriteToFileSync_1("sync_1.txt", "111");
            WriteToFileSync_1("sync_2.txt", "222");
            WriteToFileSync_1("sync_3.txt", "333");
            Console.WriteLine($"TestArraySync cost time: {stopwatch.Elapsed.TotalMilliseconds}");
        }
        /// <summary>
        /// 130ms
        /// </summary>
        public async void TestArraySyncWithAwait()
        {
            Console.WriteLine("TestArraySyncWithAwait");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await WriteToFileAsync_1("sync_await_1.txt", "111");
            await WriteToFileAsync_1("sync_await_2.txt", "222");
            await WriteToFileAsync_1("sync_await_3.txt", "333");
            Console.WriteLine($"TestArraySyncWithAwait cost time: {stopwatch.Elapsed.TotalMilliseconds}");
        }
        /// <summary>
        /// 60-90ms
        /// </summary>
        public void TestArraySyncWithTask()
        {
            Console.WriteLine("TestArraySyncWithTask");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result1 = Task<string>.Run(() => WriteToFileAsync_1("sync_WithTask_1.txt", "111"));
            var result2 = Task<string>.Run(() => WriteToFileAsync_1("sync_WithTask_2.txt", "222"));
            var result3 = Task<string>.Run(()=>WriteToFileAsync_1("sync_WithTask_3.txt", "333"));
            result1.Wait();
            result2.Wait();
            result3.Wait();
            Console.WriteLine($"TestArraySyncWithTask cost time: {stopwatch.Elapsed.TotalMilliseconds}");
        }

        public string WriteToFileSync_1(string file, string message)
        {
            StreamWriter streamWriter = new StreamWriter(file, true);
            streamWriter.WriteLine(MultplyMessage(message));
            streamWriter.Flush();
            AutoResetEvent.Set();
            return "WriteLine :" + message + "To " + file;
        }

        public async Task<string> WriteToFileAsync_1(string file, string message)
        {
            return await Task<String>.Run(() =>
            {
                StreamWriter streamWriter = new StreamWriter(file, true);
                streamWriter.WriteLine(MultplyMessage(message));
                streamWriter.Flush();
                return "WriteLine :" + message + "To " + file;
            });
            
        }

        private string MultplyMessage(string message)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                stringBuilder.AppendLine(i + "------" + message);
            }
            return stringBuilder.ToString();
        }
        public async Task<string> WriteToFileAsync_2(string file, string message)
        {
            return await Task<String>.Run(() =>
            {
                StreamWriter streamWriter = new StreamWriter(file, true);
                streamWriter.WriteLine(MultplyMessage(message));
                streamWriter.Flush();
                return "WriteLine :" + message + "To " + file;
            });
        }
        public async Task<string> WriteToFileAsync_3(string file, string message)
        {
            return await Task<String>.Run(() =>
            {
                StreamWriter streamWriter = new StreamWriter(file, true);
                streamWriter.WriteLine(MultplyMessage(message));
                streamWriter.Flush();
                return "WriteLine :" + message + "To " + file;
            });
        }

        public string Console_1(string message)
        {
            Console.WriteLine("Console_1" + message);

            return message;
        }
        public string Console_2(string message)
        {
            Console.WriteLine("Console_2"+message);
            return message;
        }
        public string Console_3(string message)
        {
            Console.WriteLine("Console_3" + message);
            return message;
        }

    }
}
