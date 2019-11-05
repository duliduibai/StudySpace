using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskTest taskArray = new TaskTest();
            //taskArray.TestTaskArray();

            //taskArray.TestTaskAsync();

            taskArray.TestArraySubAsync();

            taskArray.TestArraySync();

            taskArray.TestArraySyncWithTask();

            taskArray.TestArraySyncWithAwait();

            taskArray.ParallelTest();

            taskArray.ThreadPoolTest();

            taskArray.MultyThreadTest();
            Console.ReadLine();
        }
    }
}
