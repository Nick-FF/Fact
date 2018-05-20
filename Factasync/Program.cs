using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factasync
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 val = 1;

            Task <Int64> Factmetod(int a)
            {
               
                return Task.Run(()=> {
                    for (int i = 0; i < a; i++)
                    {
                        val = val * i;
                    }
                    Console.WriteLine("{0}", val);
                    return val;
                });
            }

           
           async void Run()
            {
                Int64 result = await Factmetod(10);
            }
            Console.ReadKey();
        }
    }
}
