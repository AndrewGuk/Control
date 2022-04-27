namespace Types
{
    public static class Mathematics
    {
        public static int Factorial(int n)
        {
            if (n == 1) 
                return 1;

            return n * Factorial(n - 1);
        }
        public static int Pow(int number, int pow)
        {
            number = (int)Math.Pow(number, pow);
            return number;
        }
    }
}
