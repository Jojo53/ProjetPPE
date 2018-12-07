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
    /// Logique d'interaction pour CustomerManagerFr.xaml
    /// </summary>
    public partial class CustomerManagerFr : Page
    {
        public CustomerManagerFr()
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
            mainwindow.Body.Source = new Uri("Pages/Français/Clients/ShowCustomerFr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Affichage des Clients";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Ajouter un Client
        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Clients/AddCustomerFr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Ajout d'un Client";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Éditer un Client
        private void EditeCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Clients/EditeCustomerFr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Édition d'un Client";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Supprimer un Client
        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Clients/DeleteCustomerFr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Suppression d'un Client";
        }
        #endregion
    }
}
