using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Domein
{
    public class Event
    {
        public Event(int id, string name, string adress, DateTime date, double price)
        {
            Id = id;
            Name = name;
            Adress = adress;
            Date = date;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
    }
}
