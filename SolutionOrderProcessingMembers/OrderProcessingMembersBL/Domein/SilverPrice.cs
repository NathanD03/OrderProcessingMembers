using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class SilverPrice : IPriceCalculation
    {
        public double CalculatePrice(double basePrice)
        {
            return basePrice * 2;
        }
    }
}
