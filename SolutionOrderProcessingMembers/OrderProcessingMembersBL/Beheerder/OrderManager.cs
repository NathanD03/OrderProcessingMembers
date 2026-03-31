using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using System.Collections.Generic;

namespace OrderProcessingMembersBL.Beheerder
{
    public class OrderManager
    {
        private readonly IRepository _repo;

        public OrderManager(IRepository repo)
        {
            this._repo = repo;
        }

        // De UI geeft nu een KANT-EN-KLAAR order door!
        public void VoegOrderToe(Order nieuwOrder)
        {
            // Je kan hier later nog checks doen (bijv. checken of het event niet vol zit)
            _repo.Save(nieuwOrder);
        }

        public List<Order> GetAllOrders()
        {
            return _repo.GetAllOrders();
        }
    }
}