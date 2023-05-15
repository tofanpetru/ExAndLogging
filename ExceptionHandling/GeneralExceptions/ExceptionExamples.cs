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
                string? s = null;
                s.ToString(); // This will throw a NullReferenceException.
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught divide by zero exception: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Caught null reference exception: " + ex.Message);
            }
        }

        public static void CatchAllExceptions()
        {
            Console.WriteLine("---> CatchAllExceptions()");

            try
            {
                string? s = null;
                s.ToString(); // This will throw a NullReferenceException.
            }
            catch (Exception ex) // This block will catch any exception.
            {
                Console.WriteLine("Caught exception: " + ex.Message);
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
                string str = "NotANumber";

                int number = int.Parse(str); // This will throw a FormatException.

                Console.WriteLine("DROP DATABASE");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
