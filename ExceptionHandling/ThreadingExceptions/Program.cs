using ThreadingExceptions;

ExceptionExamples.BasicThreadException();
await ExceptionExamples.TaskExceptionAsync();
await ExceptionExamples.RaceConditionExample();

Console.WriteLine("End");
Console.ReadLine();