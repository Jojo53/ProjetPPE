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
    /// Logique d'interaction pour EditeCasting2En.xaml
    /// </summary>
    public partial class EditeCasting2En : Page
    {
        //Variables
        public static String IntitituleVar;
        public static String DateDebutPubliacationVar;
        public static String DureeDiffusionVar;
        public static String DateDebutContratVar;
        public static int NbPosteVar;

        public static string ClientIdSelected;
        public static string MetierIdSelected;
        public static string TypeContratSelected;

        public EditeCasting2En()
        {
            //Initialization
            InitializeComponent();
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Charger la liste des Clients
        private void Client_Loaded(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowCustomerCombobox(Client);
        }
        #endregion
        //-----------------------------------------------------------------
        #region Charger la liste des Metiers
        private void Metier_Loaded(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowMetierCombobox(Metier);
        }
        #endregion
        //-----------------------------------------------------------------
        #region Charger la liste des Types de Contrat
        private void TypeContrat_Loaded(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowTypeContratCombobox(TypeContrat);
        }
        #endregion
        //-----------------------------------------------------------------
        #region Bouton Modifier l'Offre de Casting
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.UpdateCasting(Localisation, Poste, Profil, Coordonnees);

            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/CastingManagerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Castings Offers Management";
        }
        #endregion
    }
}
