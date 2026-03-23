using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Interfaces
{
    public interface IOrderPrice
    {
        double BronzeCost(double cost);
        double SilverCost(double cost);
        double GoldCost(double cost);
    }
}
