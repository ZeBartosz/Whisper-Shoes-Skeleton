using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection allStock = new clsStockCollection(); 
            Assert.IsNotNull(allStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock aStock = new clsStock();
            aStock.stockId = 1;
            aStock.stockName = "Test";
            aStock.stockDescription = "TestTest";
            aStock.stockQuantity = 10;
            aStock.stockRestockThreshold = 5;
            aStock.stockLastRestocked = DateTime.Now;
            aStock.stockAutoRestock = true;

            TestList.Add(aStock);
            allStock.StockList = TestList;
            Assert.AreEqual(allStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock aStock = new clsStock();
            aStock.stockId = 1;
            aStock.stockName = "Test";
            aStock.stockDescription = "TestTest";
            aStock.stockQuantity = 10;
            aStock.stockRestockThreshold = 5;
            aStock.stockLastRestocked = DateTime.Now;
            aStock.stockAutoRestock = true;

            allStock.ThisStock = aStock;
            Assert.AreEqual(allStock.ThisStock, aStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock aStock = new clsStock();
            aStock.stockId = 1;
            aStock.stockName = "Test";
            aStock.stockDescription = "TestTest";
            aStock.stockQuantity = 10;
            aStock.stockRestockThreshold = 5;
            aStock.stockLastRestocked = DateTime.Now;
            aStock.stockAutoRestock = true;

            TestList.Add(aStock);
            allStock.StockList = TestList;
            Assert.AreEqual(allStock.Count, TestList.Count);
        }



    }

  
}
