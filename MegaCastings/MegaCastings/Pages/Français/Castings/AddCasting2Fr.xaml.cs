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
    /// Logique d'interaction pour AddCasting2Fr.xaml
    /// </summary>
    public partial class AddCasting2Fr : Page
    {
        //Variables
        public static string ClientIdSelected;
        public static string MetierIdSelected;
        public static string TypeContratSelected;

        public AddCasting2Fr()
        {
            //Initialization
            InitializeComponent();
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Charger la liste des Clients
        private void ClientBox_Loaded(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowCustomerCombobox(ClientBox);
        }
        #endregion
        //-----------------------------------------------------------------
        #region Charger la liste des Metiers
        private void MetierBox_Loaded(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowMetierCombobox(MetierBox);
        }
        #endregion
        //-----------------------------------------------------------------
        #region Charger la liste des Types de Contrat
        private void TypeContratBox_Loaded(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowTypeContratCombobox(TypeContratBox);
        }
        #endregion
        //-----------------------------------------------------------------
        #region Ajouter l'Offre de Casting
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            Customer customer = new Customer();
            bdd.ManageCasting(customer, ClientBox);
            if (customer.Nbr_castings > 0)
            {
                if (AddCastingFr.IntitituleVar == ""
                || AddCastingFr.DateDebutPubliacationVar == ""
                || AddCastingFr.DureeDiffusionVar == 0
                || AddCastingFr.DateDebutContratVar == ""
                || AddCastingFr.LocalisationVar == ""
                || PosteBox.Text == ""
                || ProfilBox.Text == ""
                || CoordonneesBox.Text == ""
                || ClientBox.SelectedIndex == -1
                || MetierBox.SelectedIndex == -1
                || TypeContratBox.SelectedIndex == -1)
                {

                }
                else
                {
                    ClientIdSelected = ClientBox.SelectedValue.ToString();
                    MetierIdSelected = MetierBox.SelectedValue.ToString();
                    TypeContratSelected = TypeContratBox.SelectedValue.ToString();
                    Casting casting = new Casting();
                    casting.intitule = AddCastingFr.IntitituleVar;
                    casting.DateDebutPublication = Convert.ToDateTime(AddCastingFr.DateDebutPubliacationVar);
                    casting.DureeDiffusion = AddCastingFr.DureeDiffusionVar;
                    casting.DateDebutContrat = Convert.ToDateTime(AddCastingFr.DateDebutContratVar);
                    casting.Localisation = AddCastingFr.LocalisationVar;
                    casting.DescriptionPoste = PosteBox.Text;
                    casting.DescriptionProfil = ProfilBox.Text;
                    casting.Coordonnees = CoordonneesBox.Text;
                    casting.ClientId = ClientBox.SelectedIndex;
                    casting.MetierId = MetierBox.SelectedIndex;
                    casting.TypeContratId = TypeContratBox.SelectedIndex;
                    customer.Nbr_castings -= 1;

                    bdd.AddCasting(casting);

                    var mainwindow = Application.Current.MainWindow as MainWindow;
                    mainwindow.Body.Source = new Uri("Pages/Français/Castings/CastingManagerFr.xaml", UriKind.RelativeOrAbsolute);
                    mainwindow.TitleWindow.Text = "Gestion des Offres de Castings";
                }
            }
            else
            {
                var mainwindow = Application.Current.MainWindow as MainWindow;
                mainwindow.Hide();
                Fenêtres.MsgErrorFr msgerrorfr = new Fenêtres.MsgErrorFr();
                msgerrorfr.Show();
            }
           
        }
        #endregion
    }
}
