// See https://aka.ms/new-console-template for more information
using TaskParallelLibrary;

const int timesRepeat = 10;
int threadId = Thread.CurrentThread.ManagedThreadId;

Console.WriteLine($"Main : Is running on thread #{threadId}");

MyParrallelClass parrallelClass = new MyParrallelClass();

Action action = new Action(parrallelClass.MyTask);

Task task = new Task(action);

task.Start(); //Запуск методу асинхронно
for(int i = 0; i < timesRepeat; i++)
{
    Console.Write(". ");
    Thread.Sleep(200);
}
Console.WriteLine($"Main : Ended on thread #{threadId}");
