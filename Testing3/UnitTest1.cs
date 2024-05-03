using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomers
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomers AnAddress = new clsCustomers();

            Assert.IsNotNull(AnAddress);
        }
    }
}
