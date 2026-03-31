using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class BronzeServices :  IMembershipService
    {
        
        public List<string> DeliverExtras()
        {
            List<string> extras = new();
            extras.Add("Standaard-levering tickets.");
            extras.Add("Naamplaatje aangemaakt.");

            return extras;
        }
    }
}
