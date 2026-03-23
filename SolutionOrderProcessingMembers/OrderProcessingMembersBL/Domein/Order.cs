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
        public string LeveringsType { get; set; }
        public virtual double CalculateTotal()
        {
            double totaal = Event.Price;
            return totaal;
        }
    }
}
