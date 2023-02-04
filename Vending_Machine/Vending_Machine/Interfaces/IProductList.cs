using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    public interface IProductList
    {
        IReadOnlyList<Product> GetProducts();
    }
}
