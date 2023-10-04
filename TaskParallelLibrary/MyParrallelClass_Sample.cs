using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    internal class MyParrallelClass_Sample
    {
        public int TimesRepeat { get; private set; }
        public int ThreadId { get; set; }
        public MyParrallelClass_Sample()
        {
            ThreadId = Thread.CurrentThread.ManagedThreadId;
            TimesRepeat = 10;
        }
        private void MyTask ()
        {
            
            Console.WriteLine($"\nMyTask : Is runnin on {ThreadId} thread !");
            for (int i = 0; i < TimesRepeat; i++)
            {
                Thread.Sleep(200);
                Console.Write("+ ");
            }
            Console.WriteLine($"\nMyTask : Is ended on thread #{ThreadId}");
        }
        public void MainTask()
        {
            //Main працює синхронно
            Console.WriteLine($"Main : Is running on thread #{ThreadId}");


            Action action = new Action(MyTask);

            Task task = new Task(action);

            task.Start(); //Запуск методу асинхронно
            for (int i = 0; i < TimesRepeat; i++)
            {
                Console.Write(". ");
                Thread.Sleep(200);
            }
            Console.WriteLine($"Main : Ended on thread #{ThreadId}");
        }
    }
}
