using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class GoldOrder : Order
    {
        public GoldOrder(int id, Lid lid, Event @event, int ticketAmount) : base(id, lid, @event, ticketAmount)
        {
        }

        public virtual string LeveringsType()
        {
            return "Express Delivery";
        }
        public override double CalculateTotal()
        {
            return base.CalculateTotal() * 3;
        }

        public override List<string> GetServices()
        {
            var services = new List<string>();
            services.Add("Nameplate");
            services.Add("Welcomepackage");
            services.Add("Taxi (Pickup)");
            services.Add("Diner");
            return services;
        }
    }
}
