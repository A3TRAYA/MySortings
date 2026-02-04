using System;

using static MySortings.ArrayProcesses;
using static MySortings.MenuGUI;


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
            var inputArray = ArrayCreate(15);
            var sortedArray = ArrayCreate(15);

            ArrayValueRandomize(inputArray);

            MenuChoice(ref inputArray, ref sortedArray);

            ArrayShowDiff(inputArr: inputArray, sortedArr: sortedArray);

            Console.ReadKey();
        }
    }
}