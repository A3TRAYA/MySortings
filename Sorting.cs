using System;

namespace MySortings
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = new int[15];

            int[] sortedArray = new int[15];

            Random ran = new();
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = ran.Next(0, 100);
            }

            Console.WriteLine("Выберите тип сортировки: \n0 - Bubble");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    sortedArray = Bubble.Sort(inputArray.ToArray());
                    break;

                default:
                    break;

            }

            Console.Write($" Input array: {string.Join(", ", inputArray)}");

            Console.WriteLine($"\n Sorted array: {string.Join(", ", sortedArray)}");
        }
    }
}