using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);

        }

        [TestMethod]
        public void AutoRestockOK()
        {
            clsStock aStock = new clsStock();
            Boolean TestData = true;
            aStock.stockAutoRestock = TestData;
            Assert.AreEqual(aStock.stockAutoRestock, TestData);
        }

        [TestMethod]
        public void  LastRestockOk()
        {
            clsStock aStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            aStock.stockLastRestocked = TestData;
            Assert.AreEqual(aStock.stockLastRestocked, TestData);
        }

        [TestMethod]
        public void RestockThresholdOK() 
        {
            clsStock aStock = new clsStock();
            int TestData = 15;
            aStock.stockRestockThreshold = TestData;
            Assert.AreEqual(aStock.stockRestockThreshold, TestData);
        }

        [TestMethod]
        public void stockQuantityOK() 
        {
            clsStock aStock = new clsStock();
            int TestData = 10;
            aStock.stockQuantity = TestData;
            Assert.AreEqual(aStock.stockQuantity, TestData);
        }

        [TestMethod]
        public void stockDescriptionOK()
        {
            clsStock aStock = new clsStock();
            string TestData = "Whisper Shoes";
            aStock.stockDescription = TestData;
            Assert.AreEqual(aStock.stockDescription, TestData); 
        }

        [TestMethod]
        public void stockNameOK() 
        { 
            clsStock aStock = new clsStock();
            string TestData = "Adidas";
            aStock.stockName = TestData;
            Assert.AreEqual(aStock.stockName, TestData);
        }

    }
}
