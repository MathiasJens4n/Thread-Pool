using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Opgave_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch mywatch = new Stopwatch(); Console.WriteLine("Thread Pool Execution");

            mywatch.Start();
            ProcessWithThreadPool();
            mywatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());

            mywatch.Reset();

            Console.WriteLine("Thread Execution");

            mywatch.Start();
            ProcessWithThread();
            mywatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());

            Console.ReadKey();
        }
        public static void ProcessWithThread()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread t = new Thread(Process);
                t.Start();
            }
        }
        public static void ProcessWithThreadPool()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
        //You have to provide a object to your method, even if you're not going to use it, since the WaitCallBack delegate wants an object as argument
        public static void Process(object obj)
        {

        }
    }
}
