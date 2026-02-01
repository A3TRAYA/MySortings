using System;

namespace MySortings
{
    enum SortType
    {
        Bubble,
        Insertion,
        Selection,
        Heap,
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = CreateArray(15);
            int[] sortedArray = CreateArray(15);

            ArrayValueRandomize(inputArray);

            Console.WriteLine("Choose the sort type: \n0 - Bubble \n1 - Insertion" +
                              "\n2 - Selection \n3 - Heap");

            string? inputSelect = Console.ReadLine();
            if (int.TryParse(inputSelect ?? "", out int value))
            {
                SortType convertedInputSelect = (SortType)value;
                switch (convertedInputSelect)
                {
                    case SortType.Bubble:
                        sortedArray = Bubble.Sort(inputArray.ToArray());
                        break;

                    case SortType.Insertion:

                        break;

                    case SortType.Selection:

                        break;

                    case SortType.Heap:

                        break;

                    default:
                        Console.WriteLine("Nothing.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                Console.ReadKey();
                return;
            }

            ShowArrayDiff(inputArr: inputArray, sortedArr: sortedArray);

            Console.ReadKey();
        }


        static int[] CreateArray(int arr_size)
        {
            int[] array = new int[arr_size];
            return array;
        }

        static void ArrayValueRandomize(int[] arr)
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

        static void ShowArrayDiff(int[] inputArr, int[] sortedArr)
        {
            Console.Write($" Input array: {string.Join(", ", inputArr)}");
            Console.WriteLine($"\n Sorted array: {string.Join(", ", sortedArr)}");
        }
    }
}