using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    internal class AsyncAwait_Sample
    {
        private void Operation()
        {
            Console.WriteLine($"Operation Thread Id : {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Begin");
            Thread.Sleep(2000);
            Console.WriteLine("End");
        }
        private async void OperationAsync()
        {
            // Id потоку співпадає з Id основного потоку. А це означає,
            // що даний метод починає виконуватись в контексті первинного потоку.
            Console.WriteLine($"OperationAsync (Part I) ThreadId : {Thread.CurrentThread.ManagedThreadId}");
            Task task = new Task(Operation);
            task.Start();
            await task;
            // Id потоку співпадає з Id вторинного потоку. А це означає,
            // що даний метод починає виконуватись в контексті вторинного потоку.
            Console.WriteLine($"OperationAsync (Part II) ThreadId : {Thread.CurrentThread.ManagedThreadId}");
        }

        public void MainOperation()
        {
            Console.WriteLine($"Main Thread Id : {Thread.CurrentThread.ManagedThreadId}");
            OperationAsync();

            Console.ReadKey();
        }
    }
}
