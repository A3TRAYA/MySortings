namespace MySortings
{
    class ArrayProcesses
    {
        public static int[] ArrayCreate(int arr_size)
        {
            int[] array = new int[arr_size];
            return array;
        }

        public static void ArrayValueRandomize(int[] arr)
        {
            Random ran = new();

            foreach (var item in arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = ran.Next(0, 100);
                }
            }
        }

        public static void ArrayShowDiff(int[] inputArr, int[] sortedArr)
        {
            Console.Write($" Input array: {string.Join(", ", inputArr)}");
            Console.WriteLine($"\n Sorted array: {string.Join(", ", sortedArr)}");
        }
    }
}