using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersDL;


namespace OrderProcessingMembersDL
{
    public class MemoryRepository : IRepository
    {


        List<Event> events = new List<Event>();
        List<Lid> members = new List<Lid>();
        List<Order> orders = new List<Order>();
        List<Lid> admins = new List<Lid>();

        // Een standaard netwerkevent
        Event event1 = new Event(1, "Tech Networking Night", "Klein Turkije 7, 9000 Gent", new DateTime(2026, 05, 15), 44.99);

        // Een duurder gala (interessant voor de prijszetting van Gold/Silver)
        Event event2 = new Event(2, "Gala der Leden", "Kouter 1, 9000 Gent", new DateTime(2026, 06, 20), 120.00);

        // Een goedkope workshop
        Event event3 = new Event(3, "Workshop Automatisering", "Technologiepark 1, 9052 Zwijnaarde", new DateTime(2026, 09, 10), 25.00);

        // Een internationaal congres
        Event event4 = new Event(4, "International Member Summit", "Veldstraat 10, 9000 Gent", new DateTime(2026, 11, 05), 250.00);

        // Bronze lid: betaalt 100 euro extra en krijgt een naamplaatje [cite: 11, 12]
        Lid lid1 = new Lid(1, "Jan", "Janssens", "jan.janssens@gmail.com","Bosstraat 5, 9000 Gent", "Bronze");

        // Silver lid: dubbele prijs, express-levering, welkomstpakket en diner [cite: 8, 9, 13, 14]
        Lid lid2 = new Lid(2, "Marie", "Peeters","peetersmarie@icloud.com", "Kouter 10, 9000 Gent", "Silver");

        // Gold lid: 3x prijs, express-levering, welkomstpakket, diner en taxi [cite: 8, 9, 15]
        Lid lid3 = new Lid(3, "Tom", "Mertens", "mertenstom@outlook.com","Veldstraat 1, 9000 Gent", "Gold");

        // Standaard lid: standaard prijs, post-levering, geen extra's [cite: 10]
        Lid lid4 = new Lid(4, "Annelies", "De Smet","desmet.annelies@telenet.be", "Stationstraat 5, 9000 Gent", "Standard");

        Lid lid5 = new Lid(5, "Jos", "Smet", "joske@gmail.com", "Vliegtuiglaan 5, 9000 Gent", "Standard");

        Lid lid6 = new Lid(6, "Pieter", "Claes", "pieter.claes@hotmail.com", "Dorpstraat 12, 9000 Gent", "Bronze");


        public void AddMember(Lid lid)
        {
            members.Add(lid);
        }

        int orderId = 0;

        public void AddOrder(Lid lid, Event gekozenEvent, int aantalTickets)
        {
            if (lid.Status == "Bronze")
            {
                orders.Add(new BronzeOrder(orderId, lid, gekozenEvent, aantalTickets));
                orderId++;
            }
            else if (lid.Status == "Silver")
            {
                orders.Add(new SilverOrder(orderId, lid, gekozenEvent, aantalTickets));
                orderId++;
            }
            else if (lid.Status == "Gold")
            {
                orders.Add(new GoldOrder(orderId, lid, gekozenEvent, aantalTickets));
                orderId++;
            }
            else
            {
                orders.Add(new Order(orderId, lid, gekozenEvent, aantalTickets));
                orderId++;
            }
        }

        public bool Exists(Lid lid)
        {
            if(members.Any(m => m.Id == lid.Id))
            {
                return true;
            }
            return false;
        }

        public Lid GetLid(int id)
        {
            return members.FirstOrDefault(m => m.Id == id);
        }

        public void AddEvent(Event @event)
        {
            events.Add(@event);
        }

        public void ProcessOrder(Order order)
        {
            
        }

        public MemoryRepository()
        {
            // Voeg de events toe aan de repository
            AddEvent(event1);
            AddEvent(event2);
            AddEvent(event3);
            AddEvent(event4);
            // Voeg de leden toe aan de repository
            AddMember(lid1);
            AddMember(lid2);
            AddMember(lid3);
            AddMember(lid4);
            AddMember(lid5);
            AddMember(lid6);

            admins.Add(lid5);
        }
    }
}
