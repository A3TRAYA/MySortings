namespace MySortings
{
    static public class Bubble
    {
        public static int[] Sort(int[] source)
        {
            if (source == null || source.Length == 0)
            {
                return Array.Empty<int>();
            }

            var array = new int[source.Length];
            Array.Copy(source, array, source.Length);

            bool isSorted = false;
            int lastElement = array.Length - 1;

            while (isSorted == false)
            {
                bool isClean = true;

                for (int i = 0; i < lastElement; i++)
                {
                    if (array[i] >= array[i + 1])
                    {
                        isClean = false;
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }

                lastElement--;

                if (lastElement == 0 || isClean == true)
                {
                    isSorted = true;
                }
            }

            return array;
        }


        private static void Swap(ref int x, ref int y)
        {
            (y, x) = (x, y);
        }
    }
}