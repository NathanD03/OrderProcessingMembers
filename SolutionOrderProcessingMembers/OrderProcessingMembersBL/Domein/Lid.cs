using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class Lid
    {
        public Lid(int id, string firstName, string lastName, string email, string adress, string status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
            Status = status;

        }

        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Status { get; set; }


    }
}
