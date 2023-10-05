// See https://aka.ms/new-console-template for more information
using TaskParallelLibrary;
MyParrallelClass_Sample parrallelClass = new MyParrallelClass_Sample();
parrallelClass.MainTask();
Main();
Console.ReadKey();


static async Task Main()
{
    Console.WriteLine($"Main Thread Id: {System.Threading.Thread.CurrentThread.ManagedThreadId}");

    await RunAsyncOperation();

    Console.WriteLine("Main End");
}

static async Task RunAsyncOperation()
{
    Console.WriteLine($"AsyncOperation Thread Id: {System.Threading.Thread.CurrentThread.ManagedThreadId}");

    // Simulate an asynchronous operation with await
    await Task.Delay(1000);

    Console.WriteLine("AsyncOperation End");
}