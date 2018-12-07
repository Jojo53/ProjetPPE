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
    /// Logique d'interaction pour EditeCastingEn.xaml
    /// </summary>
    public partial class EditeCastingEn : Page
    {
        //Variables
        public static String IdSelected;

        public static String IntituleVar;
        public static String DateDebutPubliacationVar;
        public static int DureeDiffusionVar;
        public static String DateDebutContratVar;

        public EditeCastingEn()
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
        #region Charger la liste des Offres de Castings
        private void ListUpdCastings_Loaded(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowCastingCombobox(ListUpdCastings);
        }
        #endregion
        //-----------------------------------------------------------------
        #region Selectionner l'Offre de Casting à Modifier
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
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/EditeCasting2En.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Edite an Casting Offer - page 2";
        }
        #endregion
    }
}
