using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Beheerder
{
    public class OrderManager
    {
        private readonly IOrderPrice _orderCost;

        public OrderManager(IOrderPrice orderCost)
        {
            this._orderCost = orderCost;
        }

       
    }
}
