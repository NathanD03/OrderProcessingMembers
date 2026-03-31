using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class Order
    {
        public int Id { get; set; }
        public Lid Lid { get; set; }
        public Event Event { get; set; }
        private readonly IPriceCalculation _priceCalculation;
        private readonly IMembershipService _membershipService;

        public Order(Lid lid, Event @event, IPriceCalculation priceCalculation, IMembershipService membershipService)
        {
            Lid=lid;
            Event=@event;
            _priceCalculation=priceCalculation;
            _membershipService=membershipService;
        }

        public double GetTotalCost()
        {
            return _priceCalculation.CalculatePrice(Event.Price);
        }

        public void ProcessOrder()
        {
            _membershipService.DeliverExtras();
            Console.WriteLine($"Ticket voor {Event.Name} verzonden");
        }
    }
}
