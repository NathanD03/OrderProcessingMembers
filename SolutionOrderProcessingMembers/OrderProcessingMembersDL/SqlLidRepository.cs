using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;

namespace OrderProcessingMembersDL
{
    public class SqlLidRepository : ILidRepository
    {
        private string _connectionString;
        //hebben we in principe niet nodig nu

        public SqlLidRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddMember(Lid lid)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Lid lid)
        {
            throw new NotImplementedException();
        }


        public Lid GetLid(int lidId)
        {
            throw new NotImplementedException();
        }
    }
}
