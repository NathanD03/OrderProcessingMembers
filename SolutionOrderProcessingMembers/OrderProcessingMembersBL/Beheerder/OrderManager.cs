using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Beheerder
{
    public class OrderManager
    {
        private IRepository repository;

        public OrderManager(IRepository repository)
        {
            this.repository = repository;
        }

        public void AddOrder(Lid lid, Event gekozenEvent, int aantalTickets)
        {
            repository.AddOrder(lid, gekozenEvent, aantalTickets);
        }

        public void ProcessOrders(List<Order> orders)
        {
             repository.ProcessOrders(orders);
        }




    }
}
