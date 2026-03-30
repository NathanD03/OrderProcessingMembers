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
        public Order(int id, Lid lid, Event @event, int ticketAmount)
        {
            Id = id;
            Lid = lid;
            Event = @event;
            TicketAmount = ticketAmount;
        }

        public int Id { get; set; }
        public Lid Lid { get; set; }
        public Event Event { get; set; }

        public int TicketAmount { get; set; }

        public virtual string LeveringsType()
        {
            return "Standard Delivery";
        }
        public virtual double CalculateTotal()
        {
            double totaal = Event.Price;
            return totaal;
        }

        public virtual List<string> GetServices()
        {
            var services = new List<string>();

            return services;
        }
    }
}
