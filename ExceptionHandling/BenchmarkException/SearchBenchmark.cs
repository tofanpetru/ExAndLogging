using BenchmarkDotNet.Attributes;

namespace BenchmarkException
{
    public class SearchBenchmark
    {
        private readonly int[] _data;
        private const int ItemToSearch = int.MaxValue;

        public SearchBenchmark()
        {
            _data = Enumerable.Range(0, 100).ToArray();
        }

        [Benchmark]
        public void SearchWithException()
        {
            try
            {
                FindItem(_data, ItemToSearch);
            }
            catch (ArgumentException)
            {
                // Handle exception
            }
        }

        [Benchmark]
        public void SearchWithErrorCode()
        {
            int index;
            var result = TryFindItem(_data, ItemToSearch, out index);
        }

        private static int FindItem(int[] data, int item)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == item)
                {
                    return i;
                }
            }

            throw new ArgumentException("Item not found");
        }

        private static bool TryFindItem(int[] data, int item, out int index)
        {
            for (index = 0; index < data.Length; index++)
            {
                if (data[index] == item)
                {
                    return true;
                }
            }

            index = -1;
            return false;
        }
    }
}
