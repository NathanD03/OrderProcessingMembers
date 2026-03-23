using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class BronzeOrder : Order
    {
        public bool namePlate { get; set; }
        private double _kostBrons = 100;
        public override double CalculateTotal()
        {
            return base.CalculateTotal() + _kostBrons;
        }
    }
}
