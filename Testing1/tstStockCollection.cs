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

        [TestMethod]
        public void AddMethodOK()
        {
            // creates an instance of the class 
            clsStockCollection allStock = new clsStockCollection();
            // creates the item of test data
            clsStock aStock = new clsStock();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties 
            aStock.stockId = 1;
            aStock.stockName = "adidas";
            aStock.stockDescription = "TestTestTestTestTest";
            aStock.stockQuantity = 10;
            aStock.stockRestockThreshold = 5;
            aStock.stockLastRestocked = DateTime.Now;
            aStock.stockAutoRestock = true;
            // set thisStock to the the test data
            allStock.ThisStock = aStock;
            // add the record
            PrimaryKey = allStock.Add();
            // set the primary key of the test data
            aStock.stockId = PrimaryKey;
            // find the record
            allStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(allStock.ThisStock, aStock);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // creates an instance of the class 
            clsStockCollection allStock = new clsStockCollection();
            // creates the item of test data
            clsStock aStock = new clsStock();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties 
            aStock.stockId = 1;
            aStock.stockName = "adidas";
            aStock.stockDescription = "TestTestTestTestTest";
            aStock.stockQuantity = 10;
            aStock.stockRestockThreshold = 5;
            aStock.stockLastRestocked = DateTime.Now;
            aStock.stockAutoRestock = true;
            // set thisStock to the the test data
            allStock.ThisStock = aStock;
            // add the record
            PrimaryKey  = allStock.Add();
            // set the primary key of the test data
            aStock.stockId = PrimaryKey;
            // modify the test record
            aStock.stockName = "adidas";
            aStock.stockDescription = "TestTestTestTestTest";
            aStock.stockQuantity = 13;
            aStock.stockRestockThreshold = 7;
            aStock.stockLastRestocked = DateTime.Now;
            aStock.stockAutoRestock = false;
            // set the record based on the new data
            allStock.ThisStock = aStock;
            // update the record 
            allStock.Update();
            // find the record
            allStock.ThisStock.Find(PrimaryKey);
            // test
            Assert.AreEqual(allStock.ThisStock, aStock);



        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // creates an instance of the class 
            clsStockCollection allStock = new clsStockCollection();
            // creates the item of test data
            clsStock aStock = new clsStock();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties 
            aStock.stockId = 1;
            aStock.stockName = "adidas";
            aStock.stockDescription = "TestTestTestTestTest";
            aStock.stockQuantity = 10;
            aStock.stockRestockThreshold = 5;
            aStock.stockLastRestocked = DateTime.Now;
            aStock.stockAutoRestock = true;
            // set thisStock to the the test data
            allStock.ThisStock = aStock;
            // add the record
            PrimaryKey = allStock.Add();
            // set the primary key of the test data
            aStock.stockId = PrimaryKey;
            // find the record 
            allStock.ThisStock.Find(PrimaryKey);
            // delete the record
            allStock.Delete();
            // now find the record
            Boolean Found = allStock.ThisStock.Find(PrimaryKey);
            // test
            Assert.IsFalse(Found);
            
        }



    }

  
}
