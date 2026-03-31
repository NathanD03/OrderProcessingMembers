using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class BronzeOrder : Order
    {
        private double _kostBrons = 100;

        public BronzeOrder(int id, Lid lid, Event @event, int ticketAmount) : base(id, lid, @event, ticketAmount)
        {
        }

        public override string LeveringsType()
        {
            return "Standard Delivery";
        }
        public override double CalculateTotal()
        {
            return base.CalculateTotal() + _kostBrons;
        }

        public override List<string> GetServices()
        {
            var services = new List<string>();
            services.Add("Nameplate");
            return services;
        }
    }
}
