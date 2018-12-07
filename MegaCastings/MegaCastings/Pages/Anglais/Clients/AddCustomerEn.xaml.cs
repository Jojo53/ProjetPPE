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

namespace MegaCastings.Pages.Anglais.Clients
{
    /// <summary>
    /// Logique d'interaction pour AddCustomerEn.xaml
    /// </summary>
    public partial class AddCustomerEn : Page
    {
        public AddCustomerEn()
        {
            //Initialization
            InitializeComponent();
            MsgError.Visibility = Visibility.Hidden;
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Bouton Ajouter un Client
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (NomBox.Text == ""
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
                mainwindow.Body.Source = new Uri("Pages/Anglais/Clients/CustomerManagerEn.xaml", UriKind.RelativeOrAbsolute);
                mainwindow.TitleWindow.Text = "Customers Management";
                MsgError.Visibility = Visibility.Visible;
            }
            
        }
        #endregion
    }
}
