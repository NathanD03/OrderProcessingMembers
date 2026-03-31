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
        private IMemoryRepo _repo;
        public MemberManager(IMemoryRepo repo)
        {
            this._repo = repo;
        }


    }
}
