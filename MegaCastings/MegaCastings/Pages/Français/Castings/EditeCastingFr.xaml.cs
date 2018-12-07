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
    /// Logique d'interaction pour EditeCastingFr.xaml
    /// </summary>
    public partial class EditeCastingFr : Page
    {
        //Variables
        public static String IdSelected;

        public static string IntituleVar;
        public static String DateDebutPubliacationVar;
        public static int DureeDiffusionVar;
        public static String DateDebutContratVar;

        public EditeCastingFr()
        {
            //Intitialization
            InitializeComponent();

            //Affichage
            IntituleTitle.Visibility = Visibility.Hidden;
            Intitule.Visibility = Visibility.Hidden;
            PubTitle.Visibility = Visibility.Hidden;
            Pub.Visibility = Visibility.Hidden;
            DiffusTitle.Visibility = Visibility.Hidden;
            Diffus.Visibility = Visibility.Hidden;
            ContratTitle.Visibility = Visibility.Hidden;
            Contrat.Visibility = Visibility.Hidden;
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Charger la liste des Offres de Casting
        private void ListUpdCastings_Loaded(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowCastingCombobox(ListUpdCastings);
        }
        #endregion
        //-----------------------------------------------------------------
        #region Selectionner l'Offre de Casting à modifier
        private void Show_Click(object sender, RoutedEventArgs e)
        {
            IdSelected = ListUpdCastings.SelectedValue.ToString();

            //Affichage
            IntituleTitle.Visibility = Visibility.Visible;
            Intitule.Visibility = Visibility.Visible;
            PubTitle.Visibility = Visibility.Visible;
            Pub.Visibility = Visibility.Visible;
            DiffusTitle.Visibility = Visibility.Visible;
            Diffus.Visibility = Visibility.Visible;
            ContratTitle.Visibility = Visibility.Visible;
            Contrat.Visibility = Visibility.Visible;
        }
        #endregion
        //-----------------------------------------------------------------
        #region Bouton Suivant
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            //Variables
            IntituleVar = Intitule.Text;
            DateDebutPubliacationVar = Pub.DisplayDate.ToString();
            DureeDiffusionVar = Int32.Parse(Diffus.Text);
            DateDebutContratVar = Contrat.DisplayDate.ToString();

            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Castings/EditeCasting2Fr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Édition d'une Offre de Casting - page 2";
        }
        #endregion
    }
}
