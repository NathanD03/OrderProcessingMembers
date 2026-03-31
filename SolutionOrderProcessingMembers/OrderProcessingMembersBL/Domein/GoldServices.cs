using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class GoldServices : IMembershipService
    {

        public List<string> DeliverExtras()
        {
            List<string> extras = new();
            extras.Add("Express-levering welkomstpakket + tickets.");
            extras.Add("Uitnodiging voor diner verzonden.");
            extras.Add("Afhaalservice ingepland.");
            extras.Add("Naamplaatje aangemaakt.");

            return extras;
        }
    }
}
