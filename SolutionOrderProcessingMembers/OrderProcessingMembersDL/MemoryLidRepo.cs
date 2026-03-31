using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersDL
{
    public class MemoryLidRepo : ILidRepository
    {
        private readonly List<Lid> _members = new List<Lid>();

        public void AddMember(Lid lid)
        {
            _members.Add(lid);
        }

        public bool Exists(Lid lid)
        {
            return _members.Any(m => m.Id == lid.Id);
        }

        public Lid GetLid(int lidId)
        {
            return _members.FirstOrDefault(m => m.Id == lidId);
        }
    }
}
