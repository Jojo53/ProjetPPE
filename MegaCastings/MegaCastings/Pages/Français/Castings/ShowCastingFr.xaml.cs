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

namespace MegaCastings.Pages.Français.Castings
{
    /// <summary>
    /// Logique d'interaction pour ShowCastingFr.xaml
    /// </summary>
    public partial class ShowCastingFr : Page
    {
        public ShowCastingFr()
        {
            //Initalization
            InitializeComponent();
            BDD bdd = new BDD();
            bdd.ShowCasting(ListCastings);
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Bouton Suivant
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Castings/ShowCasting2Fr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Affichage des Offres de Castings - page 2";
        }
        #endregion
    }
}
