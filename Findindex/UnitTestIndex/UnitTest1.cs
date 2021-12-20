using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIndex
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindIndex_vmassive_Test()
        {
            int[] a = { 25, 65, 3, 9, 8,};
            int element = 9;
            int expected = 3;

            int actual = Findindex.Index.FindIndex(a, element);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindIndex_pustoimassiv_Test()
        {
            int[] a = { };
            int element = 0;
            int expected = -1;

            int actual = Findindex.Index.FindIndex(a, element);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindIndex_netelementavmassive_Test()
        {
            int[] a = { 4, 33, 6, 33, 7 };
            int element = 23;
            int expected = -1;

            int actual = Findindex.Index.FindIndex(a, element);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindIndex_poiskindexa1elementa_Test()
        {
            int[] a = { 4, 33, 6, 3, 7 };
            int element = 4;
            int expected = 0;

            int actual = Findindex.Index.FindIndex(a, element);

            Assert.AreEqual(expected, actual);

        }
    }
}
