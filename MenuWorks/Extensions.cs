namespace MySortings
{
    public static class MyExtensions
    {
        extension(int[] arr)
        {
            public bool IsValid()
            {
                if (arr == null || arr.Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        public static void Swap(ref int x, ref int y)
        {
            (y, x) = (x, y);
        }
    }
}