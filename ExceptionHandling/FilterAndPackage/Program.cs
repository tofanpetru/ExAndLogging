using FilterAndPackage;

int[] arr = { 1, 2, 3 };

try
{
    Console.WriteLine(arr.SecondMethod(5));
    //throw new ExceptionExample();
    //throw new ArithmeticException();
}
catch (Exception ex) when (ex is ArithmeticException)
{
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Ex: IndexOutOfRangeException");
}
finally
{
              