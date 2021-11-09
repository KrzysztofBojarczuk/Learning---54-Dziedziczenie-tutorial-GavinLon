using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GavinLon
{
    public abstract class Product
    {
        protected int _quantity = 0;
        public decimal Price { get; set; }
        public Product()
        {

        }
        public abstract string ProductName { get; }
        public virtual void Add()
        {
            _quantity++;
        }
        public void Remove()
        {
            if (_quantity > 0)
            {
                _quantity--;
            }
        }
        public virtual decimal GetTotalValueInStock()
        {
            return _quantity * Price;
        }

        public override string ToString()
        {
            return $"Product Name: {ProductName}, Price: {Price}, Quantity: {_quantity}, Total Value: {GetTotalValueInStock()}";
        }
    }
   
}
