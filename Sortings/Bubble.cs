namespace MySortings
{
    public static class Bubble
    {
        public static int[] Sort(int[] source)
        {
            if (!source.IsValid())
            {
                return Array.Empty<int>();
            }

            var array = new int[source.Length];
            Array.Copy(source, array, source.Length);

            
            int lastElement = array.Length - 1;
            bool isSorted = false;
            while (isSorted == false)
            {
                bool isClean = true;

                for (int i = 0; i < lastElement; i++)
                {
                    if (array[i] >= array[i + 1])
                    {
                        isClean = false;

                        MyExtensions.Swap(ref array[i], ref array[i + 1]);
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
    }
}