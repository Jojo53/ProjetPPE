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

namespace MegaCastings.Pages.Anglais.Castings
{
    /// <summary>
    /// Logique d'interaction pour CastingManagerEn.xaml
    /// </summary>
    public partial class CastingManagerEn : Page
    {
        public CastingManagerEn()
        {
            //Initialization
            InitializeComponent();
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Afficher les Offres de Castings
        private void ShowCastingButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/ShowCastingEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Show Castings Offers";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Ajouter une Offre de Casting
        private void AddCastingButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/AddCastingEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Add an Casting Offer";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Éditer une Offre de Casting
        private void EditeCastingButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/EditeCastingEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Edite an Casting Offer";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Supprimer une Offre de Casting
        private void DeleteCastingButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/DeleteCastingEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Delete an Casting Offer";
        }
        #endregion
    }
}
