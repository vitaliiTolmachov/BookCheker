using System;
using ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    [TestMethod]
    //    public void TestMethod1()
    //    {
    //        Book book = new Book();
    //        book.KnowPagesLeft(5000);
    //        Assert.IsTrue(Book.DayNorm > 0);

    //    }
    //}

    [TestFixture]
    public static class MyTestClass
    {
        [Test]
        public static void MyTest()
        {
            Book book = new Book();
            book.KnowPagesLeft(5000);
            Assert.IsTrue(Book.DayNorm < 0);
        }
    }
}
