using OrderProcessingMembersBL.Beheerder;
using OrderProcessingMembersBL.Domein;
using OrderProcessingUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OrderProcessingMembersUI
{
    /// <summary>
    /// Interaction logic for OrderTicketsWindow.xaml
    /// </summary>
    public partial class OrderTicketsWindow : Window
    {
        private Lid _ingelogdLid;
        private OrderManager _orderManager;
        private List<Event> _alleEvents;
        public OrderTicketsWindow(Lid lid, OrderManager orderManager, List<Event> events)
        {
            InitializeComponent();

            _ingelogdLid = lid;
            _orderManager = orderManager;
            _alleEvents = events;

            UserNameTextBox.Text = $"{_ingelogdLid.FirstName}";
            EventComboBox.ItemsSource = _alleEvents; 
            EventComboBox.DisplayMemberPath = "Name"; 
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            Close();
        }

        private void OrderTicketsButton_Click(object sender, RoutedEventArgs e)
        {
            // 1. Validatie: is alles ingevuld?
            if (EventComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(TicketCountTextBox.Text))
            {
                MessageBox.Show("Kies een event en vul een aantal in.");
                return;
            }

            Event gekozenEvent = (Event)EventComboBox.SelectedItem;
            int aantalTickets;

            if (!int.TryParse(TicketCountTextBox.Text, out aantalTickets))
            {
                MessageBox.Show("Vul een geldig getal in bij aantal tickets.");
                return;
            }

           
            OrderFactory factory = new OrderFactory();

            
            int nieuwOrderId = _orderManager.GetAllOrders().Count + 1;

            
            Order nieuwOrder = factory.CreateOrder(nieuwOrderId, _ingelogdLid, gekozenEvent, aantalTickets);

            // 3. OPSLAAN VIA DE MANAGER
            _orderManager.VoegOrderToe(nieuwOrder);

            // 4. Bevestiging tonen aan de gebruiker met de berekende prijs!
            double basisPrijs = gekozenEvent.Price * aantalTickets;
            double totaalPrijs = nieuwOrder.PriceCalculator.CalculateTotal(basisPrijs);

            MessageBox.Show($"Bestelling gelukt!\n\n" +
                            $"Event: {gekozenEvent.Name}\n" +
                            $"Aantal: {aantalTickets}\n" +
                            $"Te betalen: €{totaalPrijs}\n" +
                            $"Levering: {nieuwOrder.DeliveryMethod.GetDeliveryType()}",
                            "Succes");
        }
    }
}
