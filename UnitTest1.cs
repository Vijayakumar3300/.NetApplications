using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using Helper;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_PhysicalProduct()
        {
            string msg="";
            IPaymentInterface paymentObject = PaymentObjectService.GetPaymentForObjectDetails((int)PaymentItemValues.PhysicalProduct);
            bool result = paymentObject.ProcessPayment(out msg);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod_PhysicalProduct()
        {
            string msg = "";
            IPaymentInterface paymentObject = PaymentObjectService.GetPaymentForObjectDetails((int)PaymentItemValues.PhysicalProduct);
            bool result = paymentObject.ProcessPayment(out msg);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod_PhysicalProduct()
        {
            string msg = "";
            IPaymentInterface paymentObject = PaymentObjectService.GetPaymentForObjectDetails((int)PaymentItemValues.PhysicalProduct);
            bool result = paymentObject.ProcessPayment(out msg);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod_PhysicalProduct()
        {
            string msg = "";
            IPaymentInterface paymentObject = PaymentObjectService.GetPaymentForObjectDetails((int)PaymentItemValues.PhysicalProduct);
            bool result = paymentObject.ProcessPayment(out msg);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod_PhysicalProduct()
        {
            string msg = "";
            IPaymentInterface paymentObject = PaymentObjectService.GetPaymentForObjectDetails((int)PaymentItemValues.PhysicalProduct);
            bool result = paymentObject.ProcessPayment(out msg);
            Assert.AreEqual(result, true);
        }

    }
}
