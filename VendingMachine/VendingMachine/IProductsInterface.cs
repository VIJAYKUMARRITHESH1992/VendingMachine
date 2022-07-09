using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IProductsInterface
    {
        string SelectProduct(string productName, decimal price);
    }
}
