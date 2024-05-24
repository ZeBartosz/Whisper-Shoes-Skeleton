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
        string stockQuantity = "100";
        string stockRestockThreshold = "0";
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
        public void LastRestockOk()
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

        /*************** Validation ***************/
        [TestMethod]
        public void ValidMethidOK()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        //Validating stockName
        [TestMethod]
        public void StockNameMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
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
            stockName = stockName.PadRight(52, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMid()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "";
            stockName = stockName.PadRight(25, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameExtremeMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockName = "";
            stockName = stockName.PadRight(500, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        // Validating stockDescription
        [TestMethod]
        public void StockDescriptionMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockDescription = "";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockDescription = "a";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMinPlusOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockDescription = "aa";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMaxLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockDescription = "";
            stockDescription = stockDescription.PadRight(254, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockDescription = "";
            stockDescription = stockDescription.PadRight(255, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMaxPlusOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockDescription = "";
            stockDescription = stockDescription.PadRight(256, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMid()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockDescription = "";
            stockDescription = stockDescription.PadRight(127, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionExtremeMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockDescription = "";
            stockDescription = stockDescription.PadRight(500, 'a');
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        // Validating StockQuantity 
        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            int TestData = -1;
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            int TestData = 0;
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            int TestData = 1;
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            int TestData = 99;
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            int TestData = 100;
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxPlusOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            int TestData = 101;
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMid()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            int TestData = 50;
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityExtremeMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            int TestData = 500;
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityInvalidData()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string TestData = "Fail";
            String stockQuantity = Convert.ToString(TestData);
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        // Validating stockRestockThreshold



        // Validating stockLastRestocked
        [TestMethod]
        public void StockLastRestockedExtremeMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(-100);
            String stockLastRestocked = TestDate.ToString();
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLastRestockedMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(-1);
            String stockLastRestocked = TestDate.ToString();
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLastRestockedMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String stockLastRestocked = TestDate.ToString();
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLastRestockedMinPlustOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(1);
            String stockLastRestocked = TestDate.ToString();
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLastRestockedExtremeMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(1);
            String stockLastRestocked = TestDate.ToString();
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLastRestockedInvalidData()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            String stockLastRestocked = "This is not a date";
            Error = aStock.Valid(stockName, stockDescription, stockQuantity, stockRestockThreshold, stockLastRestocked);
            Assert.AreNotEqual(Error, "");
        }






    }
}