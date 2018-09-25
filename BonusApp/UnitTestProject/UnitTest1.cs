using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BonusApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Order o = new Order();
        Bonuses b = new Bonuses();
        [TestInitialize]
        public void Init()
        {
            Product p1 = new Product { Name = "bamse", Value = 10.00};
            Product p2 = new Product { Name = "PisPåFlaske", Value = 1.00 };
            Product p3 = new Product { Name = "C#", Value = 6.00 };

            o.AddProduct(p1);
            o.AddProduct(p2);
            o.AddProduct(p3);
        }
        [TestMethod]
        public void TenPercentTest()
        {

            Assert.AreEqual(1.0, b.TenProcent(10.00));
            Assert.AreEqual(0.1, b.TenProcent(1.0));
            Assert.AreEqual(0.6, b.TenProcent(6.00));
        }
        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(2.0, b.FlatTwoIfAmountMoreThanFive(10.00));
            Assert.AreEqual(0.0, b.FlatTwoIfAmountMoreThanFive(1.0));
            Assert.AreEqual(2.0, b.FlatTwoIfAmountMoreThanFive(6.00));
        }
        [TestMethod]
        public void GetValueOfProducts_Test()
        {

        }
    }
}
