using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GavinLon
{
    public class Desk : Product
    {
        public decimal ImportTaxPercentage { get; set; }
        public override string ProductName
        {
            get
            {
                return "Desk";
            }
         }

        public Desk()
        {

        }

        public override decimal GetTotalValueInStock()
        {
            decimal netTotal = base.GetTotalValueInStock() - (base.GetTotalValueInStock() * (ImportTaxPercentage / 100));
            return netTotal;
        }
    }
}
