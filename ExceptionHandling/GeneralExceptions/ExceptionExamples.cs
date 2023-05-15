namespace GeneralExceptions
{
    public class ExceptionExamples
    {
        public static void BasicTryCatch()
        {
            Console.WriteLine("---> BasicTryCatch()");

            try
            {
                string str = "NotANumber";
                int number = int.Parse(str); // This will throw a FormatException.
            }
            catch (FormatException ex)
            {
                // This block will catch the exception and handle it.
                Console.WriteLine("Caught exception: " + ex.Message);
            }
        }

        public static void MultipleCatchBlocks()
        {
            Console.WriteLine("---> MultipleCatchBlocks()");

            try
            {
                // Some code that can throw multiple types of exceptions.
                int[] numbers = { 1, 2, 3 };
                int index = 4;
                int value = numbers[index]; // This will throw an IndexOutOfRangeException.
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught IndexOutOfRangeException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught a general exception: " + ex.Message);
            }
        }

        public static void CatchAllExceptions()
        {
            Console.WriteLine("---> CatchAllExceptions()");

            try
            {
                // Some code that can throw multiple types of exceptions.
                int[] numbers = { 1, 2, 3 };
                int index = 4;
                int value = numbers[index]; // This will throw an IndexOutOfRangeException.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught a general exception: " + ex.Message);
            }
        }

        public static void TryCatchFinally()
        {
            Console.WriteLine("---> TryCatchFinally()");

            try
            {
                string str = "NotANumber";
                int number = int.Parse(str); // This will throw a FormatException.
            }
            catch (FormatException ex)
            {
                // This block will catch the exception and handle it.
                Console.WriteLine("Caught exception: " + ex.Message);
            }
            finally
            {
                // This block will always be executed, regardless of whether an exception was thrown.
                Console.WriteLine("Finally block executed.");
            }
        }

        public static void TryAndFinally()
        {
            Console.WriteLine("---> TryAndFinally()");

            try
            {
                try
                {
                    throw new ArithmeticException();
                }
                catch
                {
                    /* Describe why all exceptions will be ignored */
                    Console.WriteLine("Caught exception: ArithmeticException");
                }
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
