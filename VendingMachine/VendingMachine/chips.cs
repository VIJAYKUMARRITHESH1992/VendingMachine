using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Chips : IProductsInterface
    {
        public string SelectProduct(string prodctname, decimal price)
        {
            string res;
            decimal productPrice = Convert.ToDecimal(0.50);
            if (price >= productPrice)
            {
                res = "Thank you for puhasing Chips product";
                return res;
            }
            else
            {
                res = "You don't have enough money in your vallet, plase ad money i you vallet";
                return res;
            }
        }
    }
}
