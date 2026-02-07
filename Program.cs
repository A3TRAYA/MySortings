using System;

using static MySortings.ArrayProcesses;
using static MySortings.MenuGUI;


namespace MySortings
{
    enum SortType
    {
        Bubble,
        Selection,
        Insertion,
        Heap,
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var inputArray = ArrayCreate(15);
            var sortedArray = ArrayCreate(inputArray.Length);

            ArrayValueRandomize(inputArray);

            MenuChoice(ref inputArray, ref sortedArray);

            ArrayShowDiff(inputArr: inputArray, sortedArr: sortedArray);

            Console.ReadKey();
        }
    }
}