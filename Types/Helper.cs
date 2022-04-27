namespace Types
{
    public static class Helper
    {
        public static string NumberInString(this int number)
        {
            string x = number.ToString();
            string resault = string.Empty;
            if (x.Length == 0)
                resault = "Empty string";
            for (int i = 0; i < x.Length; i++)
            {
                switch (x[i])
                {
                    case '1':
                        resault += "one ";
                        break;
                    case '2':
                        resault += "two ";
                        break;
                    case '3':
                        resault += "three ";
                        break;
                    case '4':
                        resault += "four ";
                        break;
                    case '5':
                        resault += "five ";
                        break;
                    case '6':
                        resault += "six ";
                        break;
                    case '7':
                        resault += "seven ";
                        break;
                    case '8':
                        resault += "eight ";
                        break;
                    case '9':
                        resault += "nine ";
                        break;
                    default:
                        resault += "zero ";
                        break;
                }
            }
            return resault;
        }
    }
}
