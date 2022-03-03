using NUnit.Framework;
using DesafioEdabit;

namespace NUnitTestProject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(ExpectedResult = true)]
        public static bool Test1()
        {
            return DesafiosEdabit.ReturnTrue();
        }

        [Test]
        [TestCase(3, 4, ExpectedResult = 14)]
        public static int Test2(int a, int b)
        {
            return DesafiosEdabit.FindPerimeter(a, b);
        }

        [Test]
        [TestCase(1, 2, 3, ExpectedResult = 5)]
        [TestCase(5, 5, 5, ExpectedResult = 20)]
        [TestCase(1, 0, 0, ExpectedResult = 3)]
        [TestCase(0, 7, 0, ExpectedResult = 7)]
        [TestCase(0, 0, 15, ExpectedResult = 0)]
        public static int Test3(int a, int b, int c)
        {
            return DesafiosEdabit.FootballPoints(a, b, c);
        }

        [Test]
        [TestCase(1, 0, ExpectedResult = 3600)]
        [TestCase(1, 3, ExpectedResult = 3780)]
        [TestCase(0, 30, ExpectedResult = 1800)]

        public static int Test4(int hours, int minutes)
        {
            return DesafiosEdabit.Convert(hours, minutes);
        }

        [Test]
        [TestCase(5, 4, ExpectedResult = 8)]
        [TestCase(8, 3, ExpectedResult = 10)]
        [TestCase(7, 9, ExpectedResult = 15)]
        [TestCase(10, 4, ExpectedResult = 13)]
        [TestCase(7, 2, ExpectedResult = 8)]

        public static int Test5(int side1, int side2)
        {
            return DesafiosEdabit.NextEdge(side1, side2);
        }

        [Test]
        [TestCase(1, 1, ExpectedResult = 60)]
        [TestCase(10, 1, ExpectedResult = 600)]
        [TestCase(10, 25, ExpectedResult = 15000)]
        [TestCase(500, 60, ExpectedResult = 1800000)]
        [TestCase(0, 60, ExpectedResult = 0)]
        [TestCase(99, 1, ExpectedResult = 5940)]
        [TestCase(419, 70, ExpectedResult = 1759800)]
        [TestCase(52, 33, ExpectedResult = 102960)]
        public static int Test6(int a, int b)
        {
            return DesafiosEdabit.Frames(a, b);
        }

        [Test]
        [TestCase(0.2, 50, 9, ExpectedResult = true)]
        [TestCase(0.9, 1, 2, ExpectedResult = false)]
        [TestCase(0.9, 3, 2, ExpectedResult = true)]
        [TestCase(0.33, 10, 3.30, ExpectedResult = true)]
        [TestCase(0, 1000, 0.01, ExpectedResult = false)]
        [TestCase(0.1, 1000, 7, ExpectedResult = true)]
        [TestCase(0, 0, 0, ExpectedResult = false)]
        public static bool Test7(double prob, int prize, double pay)
        {
            return DesafiosEdabit.ProfitableGamble(prob, prize, pay);
        }

        [Test]
        [TestCase(2013, 12, 24, ExpectedResult = true)]
        [TestCase(2013, 0, 23, ExpectedResult = false)]
        [TestCase(3000, 12, 24, ExpectedResult = true)]
        public static bool Test8(int year, int month, int day)
        {
            return DesafiosEdabit.TimeForMilkAndCookies(year, month, day);
        }

        [Test]
        [TestCase(1, ExpectedResult = 6)]
        [TestCase(2, ExpectedResult = 24)]
        [TestCase(3, ExpectedResult = 54)]
        [TestCase(4, ExpectedResult = 96)]
        [TestCase(5, ExpectedResult = 150)]
        [TestCase(6, ExpectedResult = 216)]
        [TestCase(7, ExpectedResult = 294)]
        [TestCase(8, ExpectedResult = 384)]
        [TestCase(9, ExpectedResult = 486)]
        [TestCase(10, ExpectedResult = 600)]
        [TestCase(11, ExpectedResult = 726)]
        [TestCase(12, ExpectedResult = 864)]
        [TestCase(13, ExpectedResult = 1014)]
        [TestCase(14, ExpectedResult = 1176)]
        [TestCase(15, ExpectedResult = 1350)]
        public static int Test9(int a)
        {
            return DesafiosEdabit.HowManyStickers(a);
        }

        [Test]
        [TestCase(1, ExpectedResult = "Enero")]
        [TestCase(10, ExpectedResult = "Octubre")]
        [TestCase(12, ExpectedResult = "Diciembre")]
        [TestCase(18, ExpectedResult = "Error")]
        public static string Test10(int a)
        {
            return DesafiosEdabit.MonthName(a);
        }



        [Test]
        [TestCase(new double[] { 1, 25, 17 }, ExpectedResult = new double[] { 1, 25 })]
        [TestCase(new double[] { 11, 2521, 17, 100, }, ExpectedResult = new double[] { 11, 2521 })]
        [TestCase(new double[] { 88124, 25, 17, 2151, 52, 2 }, ExpectedResult = new double[] { 2, 88124 })]
        [TestCase(new double[] { 99, 1232 }, ExpectedResult = new double[] { 99, 1232 })]
        [TestCase(new double[] { }, ExpectedResult = null)]
        [TestCase(new double[] { 5 }, ExpectedResult = new double[] { 5, 5 })]
        public static double[] Test11(double[] values)
        {
            return DesafiosEdabit.FindMinMax(values);
        }

        [Test]
        [TestCase(new int[] { 1, 0, -1 }, ExpectedResult = 2)]
        [TestCase(new int[] { 2, 2, -2 }, ExpectedResult = 6)]
        [TestCase(new int[] { 3, 3, 3 }, ExpectedResult = 9)]
        public static int Test12(int[] arr)
        {
            return DesafiosEdabit.GetAbsSum(arr);
        }

        [Test]
        [TestCase (1,1, ExpectedResult = 1)]
        [TestCase(2, 5, ExpectedResult = 32)]
        [TestCase(3, 8 , ExpectedResult = 6561)]
        [TestCase(11, 0, ExpectedResult = 1)]
        [TestCase(0, 0, ExpectedResult = 1)]

        public static long Test13(long a, long b)
        {
            return DesafiosEdabit.CalculateExponent(a, b);
        }

        [Test]
        [TestCase(new int[] { 2, 3, 1, 0 }, ExpectedResult = new int[] { 8, 12, 4, 0 })]
        [TestCase(new int[] { 4,1,1 }, ExpectedResult = new int[] { 12,3,3 })]
        [TestCase(new int[] { 1, 0, 3, 3, 7, 2, 1 }, ExpectedResult = new int[] { 7, 0, 21, 21, 49, 14, 7 })]
        public static int[] Test14(int[] arr)
        {
            return DesafiosEdabit.MultiplyByLength(arr);
        }

        [Test]
        [TestCase("kalbk","aqldk", ExpectedResult = 3)]
        [TestCase("abcde", "abcde", ExpectedResult = 0)]
        [TestCase("lllaq", "llkaq", ExpectedResult = 1)]
        [TestCase("jeldq", "afxtl", ExpectedResult = 5)]

        public static int Test15(string a, string b)
        {
            return DesafiosEdabit.HammingDistance(a, b);
        }

        [Test]
        [TestCase("Elian Remaggi", ExpectedResult = "Remaggi Elian")]
        [TestCase("Juan Gut", ExpectedResult = "Gut Juan")]

        public static string Test16(string str)
        {
            return DesafiosEdabit.NameShuffle(str);
        }

        [Test]
        [TestCase("164", "847", ExpectedResult = "164")]
        [TestCase("1", "5", ExpectedResult = "1")]
        [TestCase("152", "38", ExpectedResult = "38")]
        [TestCase("16", "16", ExpectedResult = "16")]
        [TestCase("88", "64", ExpectedResult = "64")]
        public static string Test17(string a, string b)
        {
            return DesafiosEdabit.smallerNum(a, b);
        }

        [Test]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(5, ExpectedResult = 120)]
        [TestCase(12, ExpectedResult = 479001600)]
        public static int Test18(int u)
        {
            return DesafiosEdabit.Factorial(u);
        }
    }
}

