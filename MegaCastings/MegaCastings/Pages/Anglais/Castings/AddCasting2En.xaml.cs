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
    /// Logique d'interaction pour AddCasting2En.xaml
    /// </summary>
    public partial class AddCasting2En : Page
    {
        //Variables
        public static string ClientIdSelected;
        public static string MetierIdSelected;
        public static string TypeContratSelected;

        public AddCasting2En()
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
            if(customer.Nbr_castings > 0)
            {
                if (AddCastingEn.IntitituleVar == ""
                || AddCastingEn.DateDebutPubliacationVar == ""
                || AddCastingEn.DureeDiffusionVar == 0
                || AddCastingEn.DateDebutContratVar == ""
                || AddCastingEn.LocalisationVar == ""
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
                    casting.intitule = AddCastingEn.IntitituleVar;
                    casting.DateDebutPublication = Convert.ToDateTime(AddCastingEn.DateDebutPubliacationVar);
                    casting.DureeDiffusion = AddCastingEn.DureeDiffusionVar;
                    casting.DateDebutContrat = Convert.ToDateTime(AddCastingEn.DateDebutContratVar);
                    casting.Localisation = AddCastingEn.LocalisationVar;
                    casting.DescriptionPoste = PosteBox.Text;
                    casting.DescriptionProfil = ProfilBox.Text;
                    casting.Coordonnees = CoordonneesBox.Text;
                    casting.ClientId = ClientBox.SelectedIndex;
                    casting.MetierId = MetierBox.SelectedIndex;
                    casting.TypeContratId = TypeContratBox.SelectedIndex;
                    customer.Nbr_castings -= 1;

                    
                    bdd.AddCasting(casting);

                    var mainwindow = Application.Current.MainWindow as MainWindow;
                    mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/CastingManagerEn.xaml", UriKind.RelativeOrAbsolute);
                    mainwindow.TitleWindow.Text = "Castings Offers Management";
                }
            }
            else
            {
                var mainwindow = Application.Current.MainWindow as MainWindow;
                mainwindow.Hide();
                Fenêtres.MsgErrorEn msgerroren = new Fenêtres.MsgErrorEn();
                msgerroren.Show();
            }

        }
        #endregion
    }
}
