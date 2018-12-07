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
    /// Logique d'interaction pour CustomerManagerEn.xaml
    /// </summary>
    public partial class CustomerManagerEn : Page
    {
        public CustomerManagerEn()
        {
            //Initialization
            InitializeComponent();
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Afficher les Clients
        private void ShowCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Clients/ShowCustomerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Show Customers";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Ajouter un Client
        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Clients/AddCustomerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Add a Customer";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Éditer un Client
        private void EditeCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Clients/EditeCustomerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Edite a Customer";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Supprimer un Client
        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Clients/DeleteCustomerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Delete a Customer";
        }
        #endregion
    }
}
