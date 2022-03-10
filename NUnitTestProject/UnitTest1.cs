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
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(2, 5, ExpectedResult = 32)]
        [TestCase(3, 8, ExpectedResult = 6561)]
        [TestCase(11, 0, ExpectedResult = 1)]
        [TestCase(0, 0, ExpectedResult = 1)]

        public static long Test13(long a, long b)
        {
            return DesafiosEdabit.CalculateExponent(a, b);
        }

        [Test]
        [TestCase(new int[] { 2, 3, 1, 0 }, ExpectedResult = new int[] { 8, 12, 4, 0 })]
        [TestCase(new int[] { 4, 1, 1 }, ExpectedResult = new int[] { 12, 3, 3 })]
        [TestCase(new int[] { 1, 0, 3, 3, 7, 2, 1 }, ExpectedResult = new int[] { 7, 0, 21, 21, 49, 14, 7 })]
        public static int[] Test14(int[] arr)
        {
            return DesafiosEdabit.MultiplyByLength(arr);
        }

        [Test]
        [TestCase("kalbk", "aqldk", ExpectedResult = 3)]
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

        //Create a function that takes two numbers as arguments(num, length)
        //and returns an array of multiples of num until the array length reaches length.
        [Test]
        [TestCase(7, 5, ExpectedResult = new int[] { 7, 14, 21, 28, 35 })]
        [TestCase(12, 10, ExpectedResult = new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 })]
        [TestCase(17, 7, ExpectedResult = new int[] { 17, 34, 51, 68, 85, 102, 119 })]
        [TestCase(630, 14, ExpectedResult = new int[] { 630, 1260, 1890, 2520, 3150, 3780, 4410, 5040, 5670, 6300, 6930, 7560, 8190, 8820 })]
        [TestCase(140, 3, ExpectedResult = new int[] { 140, 280, 420 })]
        [TestCase(7, 8, ExpectedResult = new int[] { 7, 14, 21, 28, 35, 42, 49, 56 })]
        [TestCase(11, 21, ExpectedResult = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 187, 198, 209, 220, 231 })]

        public int[] Test19(int num, int length)
        {
            //Arrange
            DesafiosEdabit desafioEdabit = new DesafiosEdabit();
            int[] respuesta;
            //Act
            respuesta = desafioEdabit.MultiplosArray(num, length);
            //Assert
            return respuesta;
        }

        //Create a function that takes a single string as argument and
        //returns an ordered array containing the indices of all capital letters in the string.
        [Test]
        [TestCase("eDaBiT", ExpectedResult = new int[] { 1, 3, 5 })]
        [TestCase("eQuINoX", ExpectedResult = new int[] { 1, 3, 4, 6 })]
        [TestCase("determine", ExpectedResult = new int[] { })]
        [TestCase("STRIKE", ExpectedResult = new int[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase("sUn", ExpectedResult = new int[] { 1 })]
        [TestCase("SpiDer", ExpectedResult = new int[] { 0, 3 })]
        [TestCase("accOmpAnY", ExpectedResult = new int[] { 3, 6, 8 })]
        [TestCase("@xCE#8S#i*$en", ExpectedResult = new int[] { 2, 3, 6 })]
        [TestCase("1854036297", ExpectedResult = new int[] { })]
        [TestCase("Fo?.arg~{86tUx=|OqZ!", ExpectedResult = new int[] { 0, 12, 16, 18 })]

        public int[] Test20(string argument)
        {
            //Arrange
            DesafiosEdabit desafioEdabit = new DesafiosEdabit();
            int[] respuesta;
            //Act
            respuesta = desafioEdabit.GetCapitalLetterIndex(argument);
            //Assert
            return respuesta;

        }

        //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

        [Test]
        [TestCase("HolaA", ExpectedResult = "hOLAa")]
        [TestCase("ELIAN", ExpectedResult = "elian")]
        [TestCase("poqwe", ExpectedResult = "POQWE")]
        [TestCase("LuiS", ExpectedResult = "lUIs")]
        [TestCase("str333ing", ExpectedResult = "STR333ING")]

        public string Test21(string argument)
        {
            //Arrange
            DesafiosEdabit desafioEdabit = new DesafiosEdabit();
            string result;
            //Act
            result = desafioEdabit.reverseString(argument);
            //Assert
            return result;
        }

        //Create a function that takes an array of integers and strings,
        //converts integers to strings, and returns the array as a string array.

        [Test]
        [TestCase(new object[] {123,"ABCde"}, ExpectedResult = new string[] {"123","ABCde"})]
        [TestCase(new object[] {21512,"ASFJH!J#"}, ExpectedResult = new string[] {"21512", "ASFJH!J#" })]
        [TestCase(new object[] {828184,"HJASFH$$#"}, ExpectedResult = new string[] {"828184", "HJASFH$$#" })]
        [TestCase(new object[] {0,"ASFHJ#/"}, ExpectedResult = new string[] {"0", "ASFHJ#/" })]
        public string[] Test22 (object[] argument)
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            string[] result;
            //Act
            result = desafiosEdabit.ConvertObjectArrayToString(argument);
            //Assert
            return result;
        }

        [Test]
        [TestCase("asdbombasd", ExpectedResult = "Duck!")]
        [TestCase("asdBOMBasd", ExpectedResult = "Duck!")]
        [TestCase("asdbmbasd", ExpectedResult = "There is no bomb here")]
        [TestCase("#$FbOmBFSHJ", ExpectedResult = "Duck!")]
        [TestCase("012KASHED", ExpectedResult = "There is no bomb here")]

        public string Test23 (string arg)
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            string result;
            //Act
            result = desafiosEdabit.bomba(arg);
            //Assert
            return result;
        }

//        In this challenge, you must verify the equality of two different values given the parameters a and b.

//        Both the value and type of the parameters need to be equal. The possible types of the given parameters are:

//        Numbers
//        Strings
//        Booleans (false or true)
//        What have you learned so far that will permit you to do two different checks (value and type) with a single statement?

//        Implement a function that returns true if the parameters are equal, and false if they are not.

        [Test]
        [TestCase(1,"Elian", ExpectedResult = false)]
        [TestCase(false, false, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase("Luis", true, ExpectedResult = false)]
        [TestCase(10, 11, ExpectedResult = false)]
        [TestCase(55, 55, ExpectedResult = true)]
        [TestCase(null, 55, ExpectedResult = false)]
        [TestCase(null, null, ExpectedResult = true)]


        public bool Test24(object a, object b)
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            bool result;
            //Act
            result = desafiosEdabit.CompareObjects(a, b);
            //Assert
            return result;
        }

        [Test]
        public void Test25()
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            //Act
            //Assert
            Assert.AreEqual(new double[] { 4, 56, 214 }, desafiosEdabit.doubleArray(new double[][] { new double[] { 4, 2, 1 }, new double[] { 56, 3, 4 }, new double[] { 1, 99, 2, 214 } }));
            Assert.AreEqual(new double[] { 242, 44, 123 }, desafiosEdabit.doubleArray(new double[][] { new double[] { 11, 2, 242 }, new double[] { 44, 2, 44 }, new double[] { 1, 2, 33, 123 } }));
            Assert.AreEqual(new double[] { 4, 77, 124 }, desafiosEdabit.doubleArray(new double[][] { new double[] { 2, 1, 4 }, new double[] { 77, 22, 4 }, new double[] { 4, 77, 124 } }));     
        }

        [Test]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 7)]
        [TestCase(10, ExpectedResult = 6)]
        [TestCase(6, ExpectedResult = 8)]
        [TestCase(345, ExpectedResult = 125)]
        [TestCase(72, ExpectedResult = 22)]
        [TestCase(72, ExpectedResult = 22)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(0, ExpectedResult = 0)]
        public int Test26(int num)
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            //Act
            int result;
            //Assert
            result = desafiosEdabit.CollatzConjecture(num);
            return result;
        }

        [Test]
        [TestCase("a", ExpectedResult = 65)]
        [TestCase("c", ExpectedResult = 67)]
        [TestCase("2", ExpectedResult = 50)]
        [TestCase("C", ExpectedResult = 99)]

        public int Test27(char c)
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            int result;
            //Act
            result = desafiosEdabit.Counterpart(c);
            //Assert
            return result;
        }

        [Test]
        [TestCase(1234, ExpectedResult = "43211234")]
        [TestCase(4321, ExpectedResult = "12344321")]
        [TestCase(98, ExpectedResult = "8998")]
        [TestCase(5, ExpectedResult = "55")]
        [TestCase(141, ExpectedResult = "141141")]
        [TestCase(777, ExpectedResult = "777777")]

        public string Test28(int num)
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            string result;
            //Act
            result = desafiosEdabit.ReverseAndNot(num);
            //Assert
            return result;
        }

        [Test]
        [TestCase("h*l* L**s", "oaui", ExpectedResult = "hola Luis")]
        [TestCase("*bcd*fg", "ae" , ExpectedResult = "abcdefg")]
        [TestCase("S* h* *nc*ntr*d* *n*", "eaeoaoua" , ExpectedResult = "Se ha encontrado una")]

        public string Test29(string censurado, string vocales)
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            string result;
            //Act
            result = desafiosEdabit.Censura(censurado, vocales);
            //Assert
            return result;

        }

        [Test]
        [TestCase("12/03/2020", ExpectedResult = "19/03/2020")]
        [TestCase("21/12/1989", ExpectedResult = "28/12/1989")]
        [TestCase("01/01/2000", ExpectedResult = "08/01/2000")]

        public string Test30 (string date)
        {
            //Arrange
            DesafiosEdabit desafiosEdabit = new DesafiosEdabit();
            string result;
            //Act
            result = desafiosEdabit.AWeekLater(date);
            //Assert
            return result;
        }
        
        [Test]
        [TestCase(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120, ExpectedResult = "qualified")]
        [TestCase(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 120, ExpectedResult = "qualified")]
        [TestCase(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64, ExpectedResult = "qualified")]
        [TestCase(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120, ExpectedResult = "disqualified")]
        [TestCase(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120, ExpectedResult = "disqualified")]
        [TestCase(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130, ExpectedResult = "disqualified")]
        [TestCase(new int[] { 5, 5, 10, 10, 15, 20, 50 }, 160, ExpectedResult = "disqualified")]
        [TestCase(new int[] { 5, 5, 10, 10, 15, 15, 40 }, 120, ExpectedResult = "disqualified")]
        [TestCase(new int[] { 10, 10, 15, 15, 20, 20 }, 150, ExpectedResult = "disqualified")]
        [TestCase(new int[] { 5, 5, 10, 20, 15, 15, 20, 20 }, 140, ExpectedResult = "disqualified")]

        public string Test31(int[] questions, int total)
        {
            //Arrange
            DesafiosEdabit edabit = new DesafiosEdabit();
            string result;
            //Act
            result = edabit.ImaginarCoding(questions, total);
            //Assert
            return result;
        }

        [Test]
        [TestCase(new int[] { 5, 1, 4, 3, 2 }, ExpectedResult = true)]
        [TestCase(new int[] { 55, 59, 58, 56, 57 }, ExpectedResult = true)]
        [TestCase(new int[] { -3, -2, -1, 1, 0 }, ExpectedResult = true)]
        [TestCase(new int[] { 5, 1, 4, 3, 2, 8 }, ExpectedResult = false)]
        [TestCase(new int[] { 5, 6, 7, 8, 9, 9 }, ExpectedResult = false)]
        [TestCase(new int[] { 5, 3 }, ExpectedResult = false)]

        public bool Test32(int[] array)
        {
            //Arrange
            DesafiosEdabit edabit = new DesafiosEdabit();
            bool result;
            //Act
            result = edabit.ConsecutiveNumbers(array);
            //Assert
            return result;
        }

        [Test]
        [TestCase("Marta appreciated deep perpendicular right trapezoids", ExpectedResult = true)]
        [TestCase("Someone is outside the doorway", ExpectedResult = false)]
        [TestCase("She eats super righteously", ExpectedResult = true)]
        [TestCase("Ben naps so often", ExpectedResult = true)]
        [TestCase("Cute triangles are cute", ExpectedResult = false)]
        [TestCase("Mad dislikes sharp pointy yoyos", ExpectedResult = true)]
        [TestCase("Rita asks Sam mean numbered dilemmas", ExpectedResult = true)]
        [TestCase("Marigold daffodils streaming happily.", ExpectedResult = false)]
        [TestCase("Simply wonderful laughing.", ExpectedResult = false)]

        public bool Test33(string smooth)
        {
            //Arrange
            DesafiosEdabit edabit = new DesafiosEdabit();
            bool result;
            //Act
            result = edabit.Smooth(smooth);
            //Assert
            return result;
        }

        [Test]
        [TestCase(5, 100, ExpectedResult = 24)]
        [TestCase(2, 128, ExpectedResult = 127)]
        [TestCase(3, 50, ExpectedResult = 22)]
        [TestCase(7, 98, ExpectedResult = 16)]
        [TestCase(11, 500, ExpectedResult = 49)]
        [TestCase(3, 600, ExpectedResult = 297)]
        [TestCase(7, 6, ExpectedResult = 0)]
        [TestCase(3, 1385, ExpectedResult = 688)]
        [TestCase(5, 4324, ExpectedResult = 1077)]
        [TestCase(2, 8663, ExpectedResult = 8655)]

        public int Test34(int p, int n)
        {
            //Arrange
            DesafiosEdabit edabit = new DesafiosEdabit();
            int result;
            //Act
            result = edabit.LegendreFormula(p, n);
            //Assert
            return result;
        }

        [Test]
        [TestCase("#CD5C5C", ExpectedResult = true)]
        [TestCase("#EAECEE", ExpectedResult = true)]
        [TestCase("#eaecee", ExpectedResult = true)]
        [TestCase("#CD5C58C", ExpectedResult = false, Description = "Length exceeds 6.")]
        [TestCase("#CD5C5Z", ExpectedResult = false, Description = "Alphabetic characters not in A-F.")]
        [TestCase("#CD5C&C", ExpectedResult = false, Description = "Unacceptable character.")]
        [TestCase("CD5C5C", ExpectedResult = false, Description = "Does not start with #.")]
        [TestCase("#123CCCD", ExpectedResult = false)]
        [TestCase("#0", ExpectedResult = false)]
        [TestCase("#987654", ExpectedResult = true)]
        [TestCase("#9876543", ExpectedResult = false, Description = "Length exceeds 6.")]
        [TestCase("#CCCCCC", ExpectedResult = true)]
        [TestCase("#ZCCZCC", ExpectedResult = false, Description = "Not acceptable alphabetic characters.")]
        [TestCase("#Z88Z99", ExpectedResult = false, Description = "Not acceptable alphabetic characters.")]
        [TestCase("#Z88!99", ExpectedResult = false, Description = "Unacceptable character.")]

        public bool Test35(string hex)
        {
            //Arrange
            DesafiosEdabit edabit = new DesafiosEdabit();
            bool result;
            //Act
            result = edabit.Hex(hex);
            //Assert
            return result;
        }
    }
}

