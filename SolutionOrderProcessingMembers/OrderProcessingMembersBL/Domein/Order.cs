using OrderProcessingMembersBL.Interfaces;
using System.Collections.Generic;

namespace OrderProcessingMembersBL.Domein
{
    public class Order
    {
        public int Id { get; set; }
        public Lid Lid { get; set; }
        public Event Event { get; set; }
        public int TicketAmount { get; set; }

       
        public IPriceCalculator PriceCalculator { get; set; }
        public IDeliveryMethod DeliveryMethod { get; set; }
        public IExtraServices ExtraServices { get; set; }

        public Order(int id, Lid lid, Event @event, int ticketAmount,
                     IPriceCalculator priceCalculator,
                     IDeliveryMethod deliveryMethod,
                     IExtraServices extraServices)
        {
            Id = id;
            Lid = lid;
            Event = @event;
            TicketAmount = ticketAmount;

            // Interfaces koppelen
            PriceCalculator = priceCalculator;
            DeliveryMethod = deliveryMethod;
            ExtraServices = extraServices;
        }

        public double CalculateTotal()
        {
            // Basis berekening uitvoeren
            double basePrice = Event.Price * TicketAmount;

            double totalPrice = PriceCalculator.CalculateTotal(basePrice);

            return totalPrice;
        }
    }
}