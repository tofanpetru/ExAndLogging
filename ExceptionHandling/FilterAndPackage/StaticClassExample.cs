namespace FilterAndPackage
{
    public static class StaticClassExample
    {
        public static int SecondMethod(this int[] arr, int index)
        {
            return FirstMethod(arr, index);
        }

        public static int FirstMethod(this int[] arr, int index)
        {
            return GetNumberBy(arr, index);
        }

        public static int GetNumberBy(int[] arr, int index)
        {
            return arr[index];
        }
    }
}
