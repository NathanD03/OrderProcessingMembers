using Microsoft.Extensions.Configuration;
using OrderProcessingMembersBL.Beheerder;
using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Interfaces;
using OrderProcessingUtil;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace OrderProcessingMembersUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _connectionString;
        private string _repoType;
        private OrderManager _orderManager;
        private MemberManager _memberManager;
        private List<Event> _beschikbareEvents;
        public MainWindow()
        {
            InitializeComponent();
            LeesConfig();

            _orderManager = new OrderManager(RepositoryFactory.GeefRepository(_repoType, _connectionString));
            _memberManager = new MemberManager(RepositoryFactory.GeefRepository(_repoType, _connectionString));
            GenereerDummyData();
            OrderFactory factory = new OrderFactory();
        }

        private void LeesConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var config = builder.Build();
            _connectionString = config.GetConnectionString("ADOSQLConnection");
            _repoType = config.GetSection("AppSettings")["RepoType"];
        }

        private void GenereerDummyData()
        {
            _beschikbareEvents = new List<Event> {
            new Event(1, "Tech Networking Night", "Klein Turkije 7, 9000 Gent", new DateTime(2026, 05, 15), 44.99),

            // Een duurder gala (interessant voor de prijszetting van Gold/Silver)
            new Event(2, "Gala der Leden", "Kouter 1, 9000 Gent", new DateTime(2026, 06, 20), 120.00),

            // Een goedkope workshop
            new Event(3, "Workshop Automatisering", "Technologiepark 1, 9052 Zwijnaarde", new DateTime(2026, 09, 10), 25.00),

            // Een internationaal congres
            new Event(4, "International Member Summit", "Veldstraat 10, 9000 Gent", new DateTime(2026, 11, 05), 250.00)
            };
            // Bronze lid: betaalt 100 euro extra en krijgt een naamplaatje 
            Lid lid1 = new Lid(1, "Jan", "Janssens", "jan.janssens@gmail.com", "Bosstraat 5, 9000 Gent", "Bronze");

            // Silver lid: dubbele prijs, express-levering, welkomstpakket en diner [cite: 8, 9, 13, 14]
            Lid lid2 = new Lid(2, "Marie", "Peeters", "peetersmarie@icloud.com", "Kouter 10, 9000 Gent", "Silver");

            // Gold lid: 3x prijs, express-levering, welkomstpakket, diner en taxi
            Lid lid3 = new Lid(3, "Tom", "Mertens", "mertenstom@outlook.com", "Veldstraat 1, 9000 Gent", "Gold");

            // Standaard lid: standaard prijs, post-levering, geen extra's 
            Lid lid4 = new Lid(4, "Annelies", "De Smet", "desmet.annelies@telenet.be", "Stationstraat 5, 9000 Gent", "Standard");

            Lid lid5 = new Lid(5, "Jos", "Smet", "joske@gmail.com", "Vliegtuiglaan 5, 9000 Gent", "Standard");

            Lid lid6 = new Lid(6, "Pieter", "Claes", "pieter.claes@hotmail.com", "Dorpstraat 12, 9000 Gent", "Bronze");
            
            Lid adminPetra = new Lid(5, "Petra", "Lut", "petra.lut@gmail.com", "Gent", "Standard");
            adminPetra.IsAdmin = true; 
            _memberManager.AddMember(adminPetra);

            _memberManager.AddMember(lid1);
            _memberManager.AddMember(lid2);
            _memberManager.AddMember(lid3);
            _memberManager.AddMember(lid4);
            _memberManager.AddMember(lid5);
            _memberManager.AddMember(lid6);


        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string ingevuldeNaam = NameTextBox.Text.Trim(); // txtNaam is de naam van je textbox

            // Zoek het lid op via de manager
            Lid ingelogdLid = _memberManager.GetLidByName(ingevuldeNaam);
            bool isAdminAangevinkt = IsAdminCheckBox.IsChecked == true;

            if (ingelogdLid != null)
            {
                if (isAdminAangevinkt)
                {
                    // Beveiliging: is dit wel écht een admin?
                    if (ingelogdLid.IsAdmin)
                    {
                        // Open het Admin scherm!
                        OrderProcessingWindow adminWindow = new OrderProcessingWindow(_orderManager);
                        adminWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Toegang geweigerd. Deze gebruiker heeft geen admin rechten.");
                    }
                }
                OrderTicketsWindow orderWindow = new OrderTicketsWindow(ingelogdLid, _orderManager, _beschikbareEvents);
                orderWindow.Show();
                Close();


            }
            else
            {
                MessageBox.Show("Gebruiker niet gevonden. Probeer een ander naamS");
            }
        }
    }
}