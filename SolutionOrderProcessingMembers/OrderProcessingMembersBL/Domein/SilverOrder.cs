using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class SilverOrder : Order
    {
        public bool namePkate { get; set; }
        public bool hasDiner { get; set; }

        public override double CalculateTotal()
        {
            return base.CalculateTotal() * 2;
        }
    }
}
