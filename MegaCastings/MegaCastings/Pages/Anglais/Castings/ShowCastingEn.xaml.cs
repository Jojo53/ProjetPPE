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

namespace MegaCastings.Pages.Anglais.Castings
{
    /// <summary>
    /// Logique d'interaction pour ShowCastingEn.xaml
    /// </summary>
    public partial class ShowCastingEn : Page
    {
        public ShowCastingEn()
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
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/ShowCasting2En.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Show Castings Offers - page 2";
        }
        #endregion
    }
}
