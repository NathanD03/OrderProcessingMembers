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

        Lid GetLidById (int id);
        Lid GetLidByName(string name);

        public void Save(Order order);
        public void ProcessOrder(Order order);
        List<Lid> GetAllMembers();
        List<Order> GetAllOrders();
    }
}
