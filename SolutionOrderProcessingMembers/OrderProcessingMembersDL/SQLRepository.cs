using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersDL
{
    public class SQLRepository : IRepository
    {
        private string _connectionString;

        public SQLRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddMember(Lid lid)
        {
            throw new NotImplementedException();
        }

        public void Save(Order order)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Lid lid)
        {
            throw new NotImplementedException();
        }

        public Lid GetLid(Lid lid)
        {
            throw new NotImplementedException();
        }

        public Lid GetLid(int id)
        {
            throw new NotImplementedException();
        }

        public void ProcessOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Lid> GetAllMembers()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Lid GetLidById(int id)
        {
            throw new NotImplementedException();
        }

        public Lid GetLidByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
