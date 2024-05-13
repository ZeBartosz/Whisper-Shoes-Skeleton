using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {

        //creating test data
        string stockName = "adidas";
        string stockDescription = "Description";
        string stockQuantity = "15";
        string stockRestockThreshold = "10";
        string stockLastRestocked = DateTime.Now.ToShortDateString();


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

                    /***************Find Method***************/

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Int32 StockId = 1;
            Found = aStock.Find(StockId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 stockId = 1;
            Found = aStock.Find(stockId);
            if (aStock.stockId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAutoRestockFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 stockId = 1;
            Found = aStock.Find(stockId);
            if (aStock.stockAutoRestock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastRestockFound() 
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 stockId = 1;
            Found = aStock.Find(stockId);
            if (aStock.stockLastRestocked != Convert.ToDateTime("16/04/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestRestockThresholdFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 stockId = 1;
            Found = aStock.Find(stockId);
            if (aStock.stockRestockThreshold != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 stockId = 1;
            Found = aStock.Find(stockId);
            if (aStock.stockQuantity != 25)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStockDescriptionFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 stockId = 1;
            Found = aStock.Find(stockId);
            if (aStock.stockDescription != "i like this")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStockNameFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 stockId = 1;
            Found = aStock.Find(stockId);
            if (aStock.stockName != "adidas")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        /***************Find Method***************/
        [TestMethod]
        public void ValidMethidOK()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinLessOne() 
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMin() 
        { 
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "a";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinPlusOne() 
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "aa";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxLessOne() 
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "";
            stockName = stockName.PadRight(49, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "";
            stockName = stockName.PadRight(50, 'a');
            aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxPlusOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "";
            stockName = stockName.PadRight(51, 'a');
            aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }


    }
}
