using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Factories;
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
        private readonly IOrderRepository _orderRepo;

        public OrderManager(IOrderRepository orderRepo)
        {
            this._orderRepo = orderRepo;
        }


        public void CreateOrder(Lid lid, Event @event)
        {
            IPriceCalculation priceCalc = PriceCalcFactory.GetMemberShipPrice(lid.Status) ;
            IMembershipService memberService = MemberServiceFactory.GetMembershipServices(lid.Status);

            Order newOrder = new Order(lid, @event, priceCalc, memberService);

            _orderRepo.Save(newOrder);
        }

       

       
    }
}
