using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    internal class StandardService :  IMembershipService
    {
        

        public List<string> DeliverExtras()
        {
            List<string> extras = new();

            extras.Add("Standaard-levering tickets.");


            return extras;
        }
    }
}
