using System;
using System.Linq;


namespace DesafioEdabit
{
    public class DesafiosEdabit
    {
        static void Main(string[] args)
        {

        }

        public static bool ReturnTrue()
        {
            return true;
        }

        public static bool LessThanOrEqualToZero(double a)
        {
            if (a <= 0)
                return true;

            return false;
        }
        
        public static int FindPerimeter(int length, int width)
        {
            return length*2 + width*2;
        }

        public static int FootballPoints(int wins, int draws, int losses)
        {
            return wins * 3 + draws * 1 + losses * 0;
        }

        public static int Convert(int hours, int minutes)
        {
            return hours * 3600 + minutes * 60;
        }

        public static int NextEdge(int side1, int side2)
        {
            return (side1 + side2) - 1;
        }

        public static int Frames(int minutes, int fps)
        {
            return minutes * 60 * fps;
        }

        public static bool ProfitableGamble(double prob, int prize, double pay)
        {
            return prob * prize > pay ? true : false;
        }
        public static bool TimeForMilkAndCookies(int year, int month, int day)
        {
            if (month == 12 && day == 24)
                return true;

            return false;
        }

        public static int HowManyStickers(int n)
        {
            return n * n * 6;
        }

        public enum months
        {
            January = 0,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            Septembre,
            October,
            November,
            December,
        }

        public static string MonthName(int num)
        {
            switch (num)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                default: return "Error";
            }
        }

        public static double[] FindMinMax(double[] values)
        {
            double[] minMax = new double[2];

            if (values.Length == 0)
                return null;

            minMax[0] = values.Min();
            minMax[1] = values.Max();

            return minMax;

        }

        public static int GetAbsSum(int[] arr)
        {
            int result = 0;
            foreach(int i in arr)
            {
                result += Math.Abs(i);
            }

            return result;
        }

        public static long CalculateExponent(long number, long exponent)
        {
            return (long)Math.Pow((double)number, (double)exponent);
        }

        public static int[] MultiplyByLength(int[] arr)
        {
            int[] result = new int[arr.Length];

            for(int i=0; i<arr.Length ; i++)
            {
                result[i] = arr[i] * arr.Length;
            }

            return result;
        }

        public static int HammingDistance(string str1, string str2)
        {
            char[] charString1 = str1.ToCharArray();
            char[] charString2 = str2.ToCharArray();
            int result = 0;

            for (int i = 0; i < charString1.Length; i++)
            {
                if (charString1[i] != charString2[i])
                    result++;
            }

            return result;
        }

        public static string NameShuffle(string str)
        {
            string[] splited = str.Split(" ");
            return $"{splited[1]} {splited[0]}";
        }

        public static string smallerNum(string n1, string n2)
        {
            char[] char1 = n1.ToCharArray();
            char[] char2 = n2.ToCharArray();

            if (char1.Length > char2.Length)
                return new string(char2);
            else if (char1.Length < char2.Length)
                return new string(char1);

            for (int i = 0; i < char1.Length; i++)
            {
                if (char1[i] > char2[i])
                    return new string(char2);
                else if (char1[i] < char2[i])
                    return new string(char1);
            }
            return new string(char1);
        }

        public static int Factorial(int num)
        {
            if (num == 0) return 1;

            int result = 1;

            for(int i = 1; i <= num; i++)
            {
                result = result*i;
            }
            return result;
        }
    }
}
