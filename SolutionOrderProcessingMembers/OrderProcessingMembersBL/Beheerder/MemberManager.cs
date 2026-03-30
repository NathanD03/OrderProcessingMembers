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
        private IRepository repo;
        public MemberManager(IRepository repo)
        {
            this.repo = repo;
        }
    }
}
