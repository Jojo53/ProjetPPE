using MegaCastings.bdd;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCastings.Pages.Français.Clients
{
    /// <summary>
    /// Logique d'interaction pour ShowCustomerFr.xaml
    /// </summary>
    public partial class ShowCustomerFr : Page
    {
        public ShowCustomerFr()
        {
            //Initalization
            InitializeComponent();
            BDD bdd = new BDD();
            bdd.ShowCustomer(ListCustomers);
        }
    }
}
