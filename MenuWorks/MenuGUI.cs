namespace MySortings
{
    class MenuGUI
    {
        public static readonly Dictionary<SortType, Func<int[], int[]>> SortStrategies =
        new()
        {
            [SortType.Bubble] = Bubble.Sort,
            [SortType.Insertion] = Insertion.Sort,
        };

        public static void MenuChoice(ref int[] inputArray, ref int[] sortedArray)
        {
            Console.WriteLine("Choose the sort type: \n0 - Bubble \n1 - Insertion" +
                  "\n2 - Selection \n3 - Heap");

            string? inputSelect = Console.ReadLine();

            if (int.TryParse(inputSelect ?? "", out int value))
            {
                SortType convertedInputSelect = (SortType)value;

                var defaultException = SortStrategies.GetValueOrDefault(convertedInputSelect);

                if (defaultException == null)
                {
                    Console.WriteLine("Nothing.");
                    return;
                }

                sortedArray = SortStrategies[convertedInputSelect](inputArray);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }

    }
}