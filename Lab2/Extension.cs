namespace Lab2
{
    public static class Extension
    {
        public static int FindGreatestCommonDivision(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}