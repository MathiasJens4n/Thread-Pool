using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_Pool
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 2; i++)
            {
                //Executes Task1 & Task2 with a thread delegated from the thread-pool
                //It can also be written like this: ThreadPool.QueueUserWorkItem(new WaitCallback(Task1));. But it makes no difference how you do it
                ThreadPool.QueueUserWorkItem(Task1);
                ThreadPool.QueueUserWorkItem(Task2);
            }
            Console.ReadKey();
        }
        public static void Task1(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }
        public static void Task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }
    }
}
