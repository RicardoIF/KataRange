using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace KataRange
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIntegerRangeContainsFirstCase()
        {
            int[] arrayOne = new int[4] { 2, 3, 4, 5 };
            int[] arrayExpected = new int[3] { 2, 3, 4 };
            bool contains = arrayOne.Intersect(arrayExpected).Any();
            Assert.IsTrue(contains);
        }

        [TestMethod]
        public void TestIntegerRangeContainsSecondCase()
        {
            int[] arrayOne = new int[4] { 2, 3, 4, 5 };
            int[] arrayExpected = new int[4] { -1, 1, 6, 10 };
            bool contains = arrayOne.Intersect(arrayExpected).Any();
            Assert.IsFalse(contains);
        }

        [TestMethod]
        public void ContainsGetAllPoints()
        {
            int[] arrayOne = new int[4] { 2, 3, 4, 5 };

            PruebasKataRange pruebasKataRange = new PruebasKataRange(2 , 6);

            Assert.(arrayOne, pruebasKataRange.getAllPoints());
        }
    }
}
