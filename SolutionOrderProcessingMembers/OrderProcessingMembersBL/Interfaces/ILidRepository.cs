using OrderProcessingMembersBL.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Interfaces
{
    public interface ILidRepository
    {
        public void AddMember(Lid lid);
        public bool Exists(Lid lid)
    }
}
