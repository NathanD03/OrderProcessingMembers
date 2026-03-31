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
        public OrderTicketsWindow()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
