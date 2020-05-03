using System;
using System.Collections.Generic;
using System.Text;
using Food_Ordering;

namespace Food_OrderingTests
{
    (TestClass)
    public class UnitTest1
    {
        TestMethod
        public void HamburgerMethod()
        {
            Order order = new Order();
            order.addordertype("hamburger");
            order.addordertype("cheese");
            string details = order.getorderdetails();

            Assert.AreEqual("Cheese Burger", details);
        }
        TestMethod
        public void HotdogMethod()
        {
            Order order = new Order();

            order.addordertype("hotdog");
            order.addorderingdetail("mustard", 0);
            string toppings = order.getorderdetails();

            Assert.AreEqual("hotdog with mustard", toppings);
        }
    }
}
