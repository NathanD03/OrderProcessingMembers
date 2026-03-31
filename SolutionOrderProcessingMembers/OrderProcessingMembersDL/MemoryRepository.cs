using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using System.Collections.Generic;

namespace OrderProcessingMembersDL
{
    // Hij implementeert netjes de interfaces uit de BL
    public class MemoryRepository : IRepository
    {
        private List<Lid> _members = new List<Lid>();
        private List<Order> _orders = new List<Order>();

        // --- Leden Opslag ---
        public void AddMember(Lid lid)
        {
            _members.Add(lid);
        }

        public List<Lid> GetAllMembers()
        {
            return _members;
        }

        public void Save(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return _orders;
        }

        public bool Exists(Lid lid)
        {
           return _members.Contains(lid);
        }

        public Lid GetLidById(int id)
        {

            return _members.FirstOrDefault(m => m.Id == id);
        }

        public Lid GetLidByName(string name)
        {

            return _members.FirstOrDefault(m => m.FirstName == name);
        }





        public void ProcessOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}