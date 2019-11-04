using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentSystemUnitTest;
using Payment.Controllers;
using Payment.Models;
using Payment.BLL;

namespace PaymentSystemUnitTest.Tests.Controllers
{
    [TestClass]
    public class PaymentControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreaditCardPayment(PaymentModel objpay)
        {
            objpay.AccountHolderName= "TestUser";
            objpay.Amount = 1000;
            objpay.Balance = 2000;
            objpay.CardNumber = 1233455679876;
            objpay.CVVNumber = 296;
            PaymentMVCController payController = new PaymentMVCController();
            PaymentBLL paybbl = new PaymentBLL();
            ActionResult result = payController.CreaditCardPayment(objpay);
           Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
        [TestMethod]
        public void DthPayment(DthModel dthObj)
        {
            dthObj.Operator = "TATA SKY";
            dthObj.SubscriberNumber = 123076;
            dthObj.planName = "GOLD";
            dthObj.amount = 540;
            PaymentMVCController payController = new PaymentMVCController();
            PaymentBLL paybbl = new PaymentBLL();
            ActionResult result = payController.DthPayment(dthObj);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
