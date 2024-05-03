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
    }
}
