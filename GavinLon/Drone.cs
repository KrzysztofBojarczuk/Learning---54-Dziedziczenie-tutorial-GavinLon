using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GavinLon
{
    public class Drone : Product
    {
        public int QuantityIncremented { get; set; }

        public override string ProductName
        {
            get
            {
                return "Drone";
            }
        }
    public Drone()
        {
            QuantityIncremented = 1;
        }
        public override void Add()
        {
            _quantity = _quantity + QuantityIncremented;
        }
    }
}
