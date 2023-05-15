namespace SpecialCases
{
    public static class ExceptionExamples
    {
        public static void CannotBeHandled()
        {
            try
            {
                RecursiveMethod();
                //ThrowNullReferenceException();
            }
            catch (Exception ex) when (ex is StackOverflowException)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
            }
        }

        private static void RecursiveMethod()
        {
            RecursiveMethod();
        }

        private static void ThrowNullReferenceException()
        {
            object obj = null;
            Console.WriteLine(obj.ToString());
        }
    }
}
