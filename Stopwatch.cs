using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Stopwatch
    {
        public static void CountTimer()
        {
            SWatch sw = new SWatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1000);
            }
            sw.Stop();
            Console.WriteLine("Time" + sw.Elapsed);
        }
    }
}
    }
}
