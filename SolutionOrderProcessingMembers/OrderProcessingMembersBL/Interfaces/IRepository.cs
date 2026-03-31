using OrderProcessingMembersBL.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Interfaces
{
    public interface IRepository
    {
        public void AddMember(Lid lid);
        public bool Exists(Lid lid);

        Lid GetLid (int id);

        public void AddOrder(Lid lid, Event gekozenEvent, int aantalTickets);
        public void ProcessOrder(Order order);
    }
}
