using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fact
{
    class Program
    {
        private static object lockObject = new object();
        static public float val = 1;
        static public float count = 1;
        static void Main(string[] args)
        {
        
            ThreadPool.SetMinThreads(2, 2);
            ThreadPool.SetMaxThreads(10, 10);

            for (int i = 0; i < 10; i++)
            {
                
               // Thread.CurrentThread.Name = Convert.ToString(i);
                ThreadPool.QueueUserWorkItem(new WaitCallback(Metod));
               
            }
            //Console.WriteLine("{0}, {1}", Thread.CurrentThread.ManagedThreadId, val);
            Console.ReadLine();
       
        }
        static void Metod(object state)
        {
            lock(lockObject)
            {
               
                val = val * count;
                count++;
            }
            Console.WriteLine("Поток {0}, {1}", Thread.CurrentThread.ManagedThreadId, val);
        }
    }
}
