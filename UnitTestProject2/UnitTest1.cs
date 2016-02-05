using System;
using ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UConsoleApplication2.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Book book = new Book();
            book.KnowPagesLeft(5000);
            Assert.IsTrue(Book.DayNorm < 0);

            //try
            //{
            //    Book book = new Book();
            //    book.KnowPagesLeft(5000);
            //    Assert.IsTrue(Book.DayNorm > 0);
            //}
            //catch (AssertionException ex)
            //{
            //    Console.WriteLine("DayNorm can't be less than zero");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
