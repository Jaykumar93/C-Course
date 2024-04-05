using System;
using System.Threading;
using System.Threading.Tasks;

// This is another code
/*
class Program
{
    static void Main(string[] args)
    {
        

        // Using Tasks
        Task task = Task.Run(() => DoWork());

        // Simulate the main thread doing some other work
        Console.WriteLine("\nUsing Tasks:");
        Console.WriteLine("Main Thread: Doing some other work...");
        Thread.Sleep(2000);

        // Wait for the task to complete
        Console.WriteLine("Main Thread: Waiting for task to complete...");
        task.Wait(); // This would work as expected

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void DoWork()
    {
        Console.WriteLine("Worker Thread: Starting work...");
        Thread.Sleep(3000); // Simulate some work
        Console.WriteLine("Worker Thread: Work completed.");
    }
}

*/


using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Create a cancellation token source
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        // Using Tasks
        
        Task task = Task.Run(() =>
        {
            DoWork(cancellationToken);
        });

        // Simulate the main thread waiting for some time
        Thread.Sleep(2000);

        // Cancel the task
        Console.WriteLine("\nUsing Tasks:");
        Console.WriteLine("Main Thread: Cancelling the task...");
        cancellationTokenSource.Cancel(); // Cancel the task

        // Wait for the task to complete or be canceled
        try
        {
            Console.WriteLine("Main Thread: Waiting for task to complete...");
            task.Wait(); // This will handle cancellation gracefully
        }
        catch (AggregateException ex)
        {
            Console.WriteLine($"Main Thread: Task threw an exception: {ex.InnerException.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void DoWork(CancellationToken cancellationToken)
    {
        Console.WriteLine("Worker  Task: Starting work...");
        while (!cancellationToken.IsCancellationRequested)
        {
            // Simulate some work
            Thread.Sleep(1000);
            Console.WriteLine("Worker Task: Doing some work...");
        }

        // Check if cancellation has been requested
        if (cancellationToken.IsCancellationRequested)
        {
            Console.WriteLine("Worker Task: Cancellation requested. Exiting...");
            cancellationToken.ThrowIfCancellationRequested(); // Throw if cancellation is requested
        }
    }
}

