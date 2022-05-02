using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Test);

            Console.ReadKey();
        }
        public static void Test(object obj)
        {
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            Console.WriteLine($"{Thread.CurrentThread.IsAlive}\n{Thread.CurrentThread.IsBackground}\n{Thread.CurrentThread.Priority}");
        }
        /*
         
         */
    }
}
