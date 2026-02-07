namespace MySortings
{
    public static class Selection
    {
        public static int[] Sort(int[] source)
        {
            if (!source.IsValid())
            {
                return [];
            }

            var array = new int[source.Length];
            Array.Copy(source, array, source.Length);

            for (int i = 1; i < array.Length; i++)
            {
                bool isClean = true;

                for (int k = i; k < array.Length; k++)
                {
                    if (array[i - 1] > array[k])
                    {
                        isClean = false;
                        MyExtensions.Swap(ref array[i - 1], ref array[k]);
                    }
                }
                
                if (isClean == true) return array;
            }

            return array;
        }
    }
}