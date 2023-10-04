using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    internal class MyParrallelClass
    {
        public void MyTask ()
        {
            int timesRepeat = 10;
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"\nMyTask : Is runnin on {threadId} thread !");
            for (int i = 0; i < timesRepeat; ++i)
            {
                Thread.Sleep(200);
                Console.Write("+ ");
            }
            Console.WriteLine($"\nMyTask : Is ended on thread #{threadId}");
        }
    }
}
