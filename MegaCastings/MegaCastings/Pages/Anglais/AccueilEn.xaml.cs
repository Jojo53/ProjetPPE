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

namespace MegaCastings.Pages.Anglais
{
    /// <summary>
    /// Logique d'interaction pour AccueilEn.xaml
    /// </summary>
    public partial class AccueilEn : Page
    {
        public AccueilEn()
        {
            //Initialization
            InitializeComponent();
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Gestion des Clients
        private void CustomerManagerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Clients/CustomerManagerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Customers Management";
            mainwindow.BackButton.Visibility = Visibility.Visible;
        }
        #endregion
        //-----------------------------------------------------------------
        #region Gestion des Offres de Castings
        private void CastingsManagerButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/CastingManagerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Castings Offers Management";
            mainwindow.BackButton.Visibility = Visibility.Visible;
        }
        #endregion
    }
}
