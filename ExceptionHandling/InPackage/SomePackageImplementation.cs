namespace InPackage
{
    public static class SomePackageImplementation
    {
        public static int SecondMethod(this int[] arr, int index)
        {
            return FirstMethod(arr, index);
        }

        private static int FirstMethod(this int[] arr, int index)
        {
            return GetNumberBy(arr, index);
        }

        private static int GetNumberBy(int[] arr, int index)
        {
            return arr[index];
        }
    }
}
