using System.Net.NetworkInformation;

namespace MySortings
{
    static public class Quick
    {
        static public int[] Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = 0;

            Sort(array, minIndex, pivotIndex - 1);

            Sort(array, pivotIndex + 1, maxIndex);

            return array;
        }
    }
}