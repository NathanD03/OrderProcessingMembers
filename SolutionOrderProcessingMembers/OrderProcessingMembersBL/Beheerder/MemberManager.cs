using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Beheerder
{
    public class MemberManager
    {
        private IRepository _repo;
        public MemberManager(IRepository repo)
        {
            this._repo = repo;
        }

        public void AddMember(Lid lid)
        {
            _repo.AddMember(lid);
        }
        public bool Exists(Lid lid) { return _repo.Exists(lid); }

        public List<Lid> GetAllMembers()
        {
            return _repo.GetAllMembers();
        }


        public Lid GetLidById(int id)
        {
            return _repo.GetLidById(id);

        }           

        public Lid GetLidByName(string name)
        {
            return _repo.GetLidByName(name);
        }
    }
}
