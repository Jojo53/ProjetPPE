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

namespace MegaCastings.Pages.Français.Castings
{
    /// <summary>
    /// Logique d'interaction pour CastingManagerFr.xaml
    /// </summary>
    public partial class CastingManagerFr : Page
    {
        public CastingManagerFr()
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
            mainwindow.Body.Source = new Uri("Pages/Français/Castings/ShowCastingFr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Affichage des Offres de Castings";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Ajouter une Offre de Casting
        private void AddCastingButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Castings/AddCastingFr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Ajout d'une Offre de Casting";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Éditer une Offre de Casting
        private void EditeCastingButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Castings/EditeCastingFr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Édition d'une Offre de Casting";
        }
        #endregion
        //-----------------------------------------------------------------
        #region Supprimer une Offre de Casting
        private void DeleteCastingButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Castings/DeleteCastingFr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Suppression d'une Offre de Casting";
        }
        #endregion
    }
}
