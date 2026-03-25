using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class GoldOrder : Order
    {
        public bool namePlate { get; set; } = true;
        public bool hasDiner { get; set; } = true;
        public bool hasTaxi { get; set; } = true;
        public virtual string LeveringsType()
        {
            return "Express Delivery";
        }
        public override double CalculateTotal()
        {
            return base.CalculateTotal() * 3;
        }
    }
}
