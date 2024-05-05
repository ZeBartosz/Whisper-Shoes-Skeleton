using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsReview aReview = new clsReview();
            Assert.IsNotNull(aReview);

        }
    }
}
