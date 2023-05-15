using InPackage;

int[] ints = { 1, 2, 3 };

try
{
    Console.WriteLine(ints.SecondMethod(5));
}
catch (ArithmeticException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();