namespace CustomExceptions
{
    public class ExceptionExamples
    {
        public static void BasicCustomException()
        {
            Console.WriteLine("---> BasicCustomException()");
            try
            {
                var userInput = "Invalid Input";
                if (userInput == "Invalid Input")
                {
                    throw new CustomException("The user input is invalid.");
                }
            }
            catch (CustomException ex)
            {
                // This block will catch the custom exception and handle it.
                Console.WriteLine("Caught exception: " + ex.Message);
            }
        }

        public static void CustomExceptionWithInnerException()
        {
            Console.WriteLine("---> CustomExceptionWithInnerException()");

            try
            {
                try
                {
                    string str = "NotANumber";
                    int number = int.Parse(str);
                }
                catch (FormatException ex)
                {
                    // Wrap the original exception in a custom exception.
                    throw new CustomException("User input caused a FormatException.", ex);
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Caught custom exception: " + ex.Message);
            }
        }
    }
}
