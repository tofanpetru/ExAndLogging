namespace GeneralExceptions
{
    public class Person
    {
        private int age;

        public int Age
        {
            get => age;
            set => age = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(Age), "Age cannot be negative.");
        }
    }

}
