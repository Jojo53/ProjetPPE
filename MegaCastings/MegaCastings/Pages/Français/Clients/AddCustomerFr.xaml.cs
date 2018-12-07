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
    /// Logique d'interaction pour AddCustomerFr.xaml
    /// </summary>
    public partial class AddCustomerFr : Page
    {
        public AddCustomerFr()
        {
            //Initialization
            InitializeComponent();
            MsgError.Visibility = Visibility.Hidden;
            RoleBox.Items.Add("ROLE_PROFESSIONNEL");
            RoleBox.Items.Add("ROLE_PARTENAIRE");
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Ajouter le Client
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if(NomBox.Text == "" 
                || PrenomBox.Text == ""
                || EmailBox.Text == ""
                || PasswordBox.Text == ""
                || RoleBox.SelectedIndex == -1)
            {
                MsgError.Visibility = Visibility.Visible;
            }
            else
            {
                Customer customer = new Customer();
                customer.nom = NomBox.Text;
                customer.prenom = PrenomBox.Text;
                customer.email = EmailBox.Text;
                customer.password = PasswordBox.Text;
                customer.role = RoleBox.SelectedValue.ToString();

                BDD bdd = new BDD();
                bdd.AddCustomer(customer);

                var mainwindow = Application.Current.MainWindow as MainWindow;
                mainwindow.Body.Source = new Uri("Pages/Français/Clients/CustomerManagerFr.xaml", UriKind.RelativeOrAbsolute);
                mainwindow.TitleWindow.Text = "Gestion des Clients";
                MsgError.Visibility = Visibility.Hidden;
            }
        }
        #endregion
    }
}
