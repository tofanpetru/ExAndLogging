namespace ThreadingExceptions
{
    public class ExceptionExamples
    {
        public static void BasicThreadException()
        {
            Console.WriteLine("---> BasicThreadException()");

            try
            {
                var thread = new Thread(() =>
                {
                    throw new InvalidOperationException("Exception from a separate thread!");
                });

                thread.Start();
                thread.Join();
            }
            catch (InvalidOperationException ex)
            {
                // This block will NOT catch the exception from the thread.
                Console.WriteLine("Caught exception: " + ex.Message);
            }
        }

        public static async Task TaskExceptionAsync()
        {
            Console.WriteLine("---> TaskExceptionAsync()");

            try
            {
                var task = Task.Run(() =>
                {
                    throw new InvalidOperationException("Exception from a task!");
                });

                await task;
            }
            catch (InvalidOperationException ex)
            {
                // This block will catch the exception from the task.
                Console.WriteLine("Caught exception: " + ex.Message);
            }
        }

        public static async Task RaceConditionExample()
        {
            Console.WriteLine("---> RaceConditionExample()");

            try
            {
                // This is the variable that will be shared between the two tasks.
                int sharedVariable = 0;

                // Task 1 will increment the shared variable a million times.
                var task1 = Task.Run(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                        sharedVariable++;
                });

                // Task 2 will decrement the shared variable a million times.
                var task2 = Task.Run(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                        sharedVariable--;
                });

                // Wait for both tasks to complete.
                await Task.WhenAll(task1, task2);

                // Print the final value of the shared variable.
                // Due to the race condition, this value can be different each time the code is run.
                Console.WriteLine($"Final value of shared variable: {sharedVariable}");
            }
            catch (Exception ex)
            {
                // Catch and handle any exceptions that might occur in the tasks.
                Console.WriteLine("Caught exception: " + ex.Message);
            }
        }
    }
}
