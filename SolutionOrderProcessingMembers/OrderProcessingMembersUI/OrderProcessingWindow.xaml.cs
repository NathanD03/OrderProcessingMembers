using OrderProcessingMembersBL.Beheerder;
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
    /// Interaction logic for OrderProcessingWindow.xaml
    /// </summary>
    public partial class OrderProcessingWindow : Window
    {
        private OrderManager _orderManager;
        public OrderProcessingWindow(OrderManager orderManager)
        {
            _orderManager = orderManager;
            InitializeComponent();
        }

        

        private void ProcessOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            // Maak de lijstjes eerst leeg voor het geval ze 2x klikken
            OrdersListBox.Items.Clear();
            ServicesListBox.Items.Clear();
            DeliveryListBox.Items.Clear();

            // Haal alle orders op uit de databank
            var alleOrders = _orderManager.GetAllOrders();

            foreach (var order in alleOrders)
            {
                // Vraag het order welke diensten het bevat. 
                // Dit haalt hij uit onze Bronze/Silver/GoldServices klasses!
                var benodigdeDiensten = order.ExtraServices.GetServices();

                if (benodigdeDiensten.Contains("Name tag"))
                {
                    string text = $"Order #{order.Id}: Naamplaatje printen voor {order.Lid.FirstName} {order.Lid.LastName}";
                    OrdersListBox.Items.Add(text);
                }

                // 2. Check voor diner uitnodiging
                if (benodigdeDiensten.Contains("Dinner"))
                {
                    string text = $"Order #{order.Id}: Diner uitnodiging sturen naar {order.Lid.Email}";
                    ServicesListBox.Items.Add(text);
                }

                // 3. Check voor Taxi service
                if (benodigdeDiensten.Contains("Pickup service"))
                {
                    string text = $"Order #{order.Id}: Taxi sturen naar {order.Lid.Adress} voor rit naar event '{order.Event.Name}'";
                    DeliveryListBox.Items.Add(text);
                }
            }

            MessageBox.Show("Alle orders zijn succesvol verwerkt en gesorteerd!", "Succes");
        }

    }
    }
}
