using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Class1 obj = new Class1();
            string actual = obj.GetCows(1);

            Assert.AreEqual("корова", actual);

        }

        [TestMethod]
        public void TestMethod11()
        {

            Class1 obj = new Class1();
            string actual = obj.GetCows(11);

            Assert.AreEqual("коров", actual);

        }

        [TestMethod]
        public void TestMethod112()
        {

            Class1 obj = new Class1();
            string actual = obj.GetCows(112);

            Assert.AreEqual("коров", actual);

        }

        [TestMethod]
        public void TestMethod458692()
        {

            Class1 obj = new Class1();
            string actual = obj.GetCows(458692);

            Assert.AreEqual("коровы", actual);

        }

        [TestMethod]
        public void TestMethod6()
        {

            Class1 obj = new Class1();
            string actual = obj.GetCows(6);

            Assert.AreEqual("коров", actual);

        }

        [TestMethod]
        public void TestMethod0()
        {

            Class1 obj = new Class1();
            string actual = obj.GetCows(0);

            Assert.AreEqual("коров", actual);

        }

        [TestMethod]
        public void TestMethod4()
        {

            Class1 obj = new Class1();
            string actual = obj.GetCows(4);

            Assert.AreEqual("коровы", actual);

        }

        [TestMethod]
        public void TestMethod5()
        {

            Class1 obj = new Class1();
            string actual = obj.GetCows(5);

            Assert.AreEqual("коров", actual);

        }
    }
}
