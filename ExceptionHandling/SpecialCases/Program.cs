using SpecialCases;

ExceptionExamples.CannotBeHandled();//+ InvalidOperationException, ThreadAbortException, AccessViolationException, OutOfMemoryException, BadImageFormatException and StackOverflowException
Console.WriteLine("End");
Console.ReadLine();