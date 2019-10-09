using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Common;

namespace ACM.BLTests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            //-- Arrange
            OrderController orderController = new OrderController();
            var customer = new Customer() { EmailAddress = "deborahk@insteptech.com" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };


            //-- Act
            OperationsResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReciepts: true);

            //-- Assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(0, op.MessageList.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderTestNullCustomer()
        {
            //-- Arrange
            OrderController orderController = new OrderController();
            Customer customer = null;
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };


            //-- Act
            OperationsResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReciepts: true);

            //-- Assert

        }

        [TestMethod()]
        public void PlaceOrderTestInvalidEmail()
        {
            //-- Arrange
            OrderController orderController = new OrderController();
            var customer = new Customer() { EmailAddress = "" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };


            //-- Act
            OperationsResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReciepts: true);

            //-- Assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(1, op.MessageList.Count);
            Assert.AreEqual("Email address is null", op.MessageList[0]);

        }
    }
}