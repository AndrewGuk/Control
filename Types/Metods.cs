namespace Types
{
    public static class Metods
    {
        public static void Quest1()
        {
            Random random = new Random();
            Console.WriteLine("Original array:");
            int[,] array = new int[9, 9];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(3, 9);
                    Console.Write($"{array[i, j]}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("New array:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i; j < array.GetLength(1); j++)
                {
                    array[i, j] = 1;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void Quest2()
        {
            int x = Validation("nubmer");
            Console.WriteLine(Helper.NumberInString(x));
            Console.ReadLine();

        }
        public static void Quest3()
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < random.Next(0, 50); i++)
            {
                list.Add(random.Next(1, 30));
            }
            Console.WriteLine("List:");
            Print(list);

            Console.WriteLine("Sort list -> :");
            var sortlist = list.OrderBy(n => n).ToList();
            Print(sortlist);

            double listLength = Math.Round((double)list.Count / 2, MidpointRounding.ToPositiveInfinity);
            int intlistLength = (int)listLength;
            sortlist.RemoveRange(0, intlistLength - 1);

            Console.WriteLine("Sort half list <-:");
            var halfList = sortlist.OrderByDescending(n => n).ToList();
            Print(halfList);
            Console.WriteLine("list pow:");
            for (int i = 0; i < halfList.Count; i++)
            {
                halfList[i] = (int)Math.Pow(halfList[i], 2);
            }
            Print(halfList);
            void Print(List<int> list)
            {
                foreach (var item in list)
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void Quest5()
        {
            Console.WriteLine("\t\tFactorial");
            Console.WriteLine("Factorial: \t" +
                Mathematics.Factorial(Validation("number")));

            Console.WriteLine();

            Console.WriteLine("\t\tPow");
            Console.WriteLine("New number: \t" +
                Mathematics.Pow(Validation("number"), Validation("pow")));
            Console.ReadLine();
        }
        static int Validation(string x)
        {
            Console.WriteLine($"Please, enter {x}: ");
            bool usEnterIsDouble;
            int receivedValue;
            string usEnter;
            do
            {
                usEnter = Console.ReadLine();
                usEnterIsDouble = Int32.TryParse(usEnter, out receivedValue);
                if (!usEnterIsDouble)
                {
                    NotCorrect();
                }
            }
            while (!usEnterIsDouble);
            receivedValue = int.Parse(usEnter);
            return receivedValue;
        }
        static void NotCorrect()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have entered incorrect data! try again.");
            Console.ResetColor();
        }
    }
}
