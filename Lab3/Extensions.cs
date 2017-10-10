namespace Lab3
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static long Factorial(long i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        public static StringBuilder AppendNewLine(this StringBuilder sb)
        {
            return sb.Append(Environment.NewLine);
        }
    }
}