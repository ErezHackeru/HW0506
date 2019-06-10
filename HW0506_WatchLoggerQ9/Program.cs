using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW0506_WatchLoggerQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Q1 -   {SingletonWatch.GetInstance().GetTime()}"); 
            Console.WriteLine("Press Enter 1 ");
            Console.ReadKey();

            AsyncPrinter asyncPrinter = new AsyncPrinter();
            int index = 1;
            for (int j = 0; j < 10; j++)
            {                
                for (int i = 0; i < 10; i++)
                {
                    new Thread(asyncPrinter.CheckPrintMessage).Start();
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(index++);
                    asyncPrinter.AddMessage(SingletonWatch.GetInstance().GetTime());
                    Thread.Sleep(250);                    
                }
            }
            Console.ReadKey();

        }
    }
}
