using System;
namespace Food_Ordering

{
    public class Order
    {
        string _ordertype = "";
        string _orderdetail = "";
        int _numtoppings = 0;

        public Order()
            {

            }
        public void addordertype(string ordertype)
        {
            _ordertype = ordertype;
        }
        public void addorderingdetail(string orderdetail, int numtoppings)
        {
            _orderdetail = orderdetail;
            _numtoppings = numtoppings;
        }
        public string getorderdetails()
        {
            if (_ordertype == "hamburger")
            {
                return _orderdetail + " " + _ordertype;
            }
            else if (_ordertype == "hotdog")
            {
                return _numtoppings + " " + _orderdetail + " " + _ordertype;
            }
            return "unknown Order";
        }
    }
}
