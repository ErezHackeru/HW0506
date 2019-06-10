using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0506_WatchLoggerQ9
{
    class SingletonWatch
    {
        private static SingletonWatch _instance;

        private static object key = new object();

        private SingletonWatch()
        {

        }

        public string GetTime()
        {
            //Console.Write("Time in Israel: ");
            //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));

            return $"Time in Israel: {DateTime.Now.ToString("HH:mm:ss tt")}";
        }

        public static SingletonWatch GetInstance()
        {
            if (_instance == null)
            {
                lock (key)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonWatch();
                    }
                }
            }
            return _instance;
        }
    }
}
