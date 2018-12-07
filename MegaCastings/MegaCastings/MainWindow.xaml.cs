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

namespace MegaCastings
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Initialization
            InitializeComponent();
            this.Top = 200;
            this.Left = 300;

            //Contenu
            Body.Source = new Uri("Pages/Français/ConnexionFr.xaml", UriKind.RelativeOrAbsolute);
            TitleWindow.Text = "Connexion";

            //Navigation
            Connected.Visibility = Visibility.Hidden;
            LoginOutButton.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
            FrButton.Visibility = Visibility.Hidden;
            EnLabel.Visibility = Visibility.Hidden;
            Thickness NavigationThickness = new Thickness();
            NavigationThickness.Left = 105;
            Navigation.Margin = NavigationThickness;
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Navigation
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Navigation - Contenu
        #region Reduire Application
        private void ReduceButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        #endregion
        //-----------------------------------------------------------------
        #region Taille Application
        private void SizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }
        #endregion
        //-----------------------------------------------------------------
        #region Fermer Application
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion
        //-----------------------------------------------------------------
        #region Retour
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //--------------------------------------------------------------
            //--------------------------------------------------------------
            //Retour - Contenu
            #region Français
            //--------------------------------------------------------------
            //--------------------------------------------------------------
            //Français - Contenu
            #region Gestion
            if (TitleWindow.Text == "Gestion des Clients"
                || TitleWindow.Text == "Gestion des Partenaires de Diffusion"
                || TitleWindow.Text == "Gestion des Offres de Castings")
            {
                Body.Source = new Uri("Pages/Français/AccueilFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Accueil";
                BackButton.Visibility = Visibility.Hidden;
            }
            #endregion
            //--------------------------------------------------------------
            #region Clients
            if (TitleWindow.Text == "Affichage des Clients"
                || TitleWindow.Text == "Ajout d'un Client"
                || TitleWindow.Text == "Édition d'un Client"
                || TitleWindow.Text == "Suppression d'un Client")
            {
                Body.Source = new Uri("Pages/Français/Clients/CustomerManagerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Gestion des Clients";
            }
            #endregion
            //--------------------------------------------------------------
            #region Partenaires de Diffusion
            if (TitleWindow.Text == "Affichage des Partenaires de Diffusion"
                || TitleWindow.Text == "Ajout d'un Partenaire de Diffusion"
                || TitleWindow.Text == "Édition d'un Partenaire de Diffusion"
                || TitleWindow.Text == "Suppression d'un Partenaire de Diffusion")
            {
                Body.Source = new Uri("Pages/Français/Partenaires/PartnerManagerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Gestion des Partenaires de Diffusion";
            }
            #endregion
            //--------------------------------------------------------------
            #region Offres de Castings
            if (TitleWindow.Text == "Affichage des Offres de Castings"
                || TitleWindow.Text == "Affichage des Offres de Casting - page 2"
                || TitleWindow.Text == "Ajout d'une Offre de Casting"
                || TitleWindow.Text == "Ajout d'une Offre de Casting - page 2"
                || TitleWindow.Text == "Édition d'une Offre de Casting"
                || TitleWindow.Text == "Édition d'une Offre de Casting - page 2"
                || TitleWindow.Text == "Suppression d'une Offre de Casting")
            {
                Body.Source = new Uri("Pages/Français/Castings/CastingManagerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Gestion des Offres de Castings";
            }
            #endregion
            #endregion
            //--------------------------------------------------------------
            #region Anglais
            //--------------------------------------------------------------
            //--------------------------------------------------------------
            //Anglais - Contenu
            #region Gestion
            if (TitleWindow.Text == "Customers Management"
                || TitleWindow.Text == "Partners Management"
                || TitleWindow.Text == "Castings Offers Management")
            {
                Body.Source = new Uri("Pages/Anglais/AccueilEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Home";
                BackButton.Visibility = Visibility.Hidden;
            }
            #endregion
            //--------------------------------------------------------------
            #region Clients
            if (TitleWindow.Text == "Show Customers"
                || TitleWindow.Text == "Add a Customer"
                || TitleWindow.Text == "Edite a Customer"
                || TitleWindow.Text == "Delete a Customer")
            {
                Body.Source = new Uri("Pages/Anglais/Clients/CustomerManagerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Customers Management";
            }
            #endregion
            //--------------------------------------------------------------
            #region Partenaires de Diffusion
            if (TitleWindow.Text == "Show Partners"
                || TitleWindow.Text == "Add a Partner"
                || TitleWindow.Text == "Edite a Partner"
                || TitleWindow.Text == "Delete a Partner")
            {
                Body.Source = new Uri("Pages/Anglais/Partenaires/PartnerManagerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Partners Management";
            }
            #endregion
            //--------------------------------------------------------------
            #region Offres de Castings
            if (TitleWindow.Text == "Show Castings Offers"
                || TitleWindow.Text == "Show Castings Offers - page 2"
                || TitleWindow.Text == "Add an Casting Offer"
                || TitleWindow.Text == "Add an Casting Offer - page 2"
                || TitleWindow.Text == "Edite an Casting Offer"
                || TitleWindow.Text == "Edite an Casting Offer - page 2"
                || TitleWindow.Text == "Delete an Casting Offer")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/CastingManagerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Castings Offers Management";
            }
            #endregion
            #endregion
        }
        #endregion
        #endregion
        //-----------------------------------------------------------------
        #region Langues
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Langues - Contenu
        #region Français
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Français - Contenu
        private void FrButton_Click(object sender, RoutedEventArgs e)
        {
            FrLabel.Visibility = Visibility.Visible;
            FrButton.Visibility = Visibility.Hidden;
            EnLabel.Visibility = Visibility.Visible;
            EnButton.Visibility = Visibility.Visible;

            //Connexion
            if (TitleWindow.Text == "Connection")
            {
                Body.Source = new Uri("Pages/Français/ConnexionFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Connexion";
            }

            //Accueil
            if (TitleWindow.Text == "Home")
            {
                Body.Source = new Uri("Pages/Français/AccueilFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Accueil";
                MsgConnected.Content = "Bienvenue,";
            }

            #region Clients
            //Gestion des Clients
            if (TitleWindow.Text == "Customers Management")
            {
                Body.Source = new Uri("Pages/Français/Clients/CustomerManagerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Gestion des Clients";
                MsgConnected.Content = "Bienvenue,";
            }
            //Affichage des Clients
            if (TitleWindow.Text == "Show Customers")
            {
                Body.Source = new Uri("Pages/Français/Clients/ShowCustomerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Affichage des Clients";
                MsgConnected.Content = "Bienvenue,";
            }
            //Ajout d'un Client
            if (TitleWindow.Text == "Add a Customer")
            {
                Body.Source = new Uri("Pages/Français/Clients/AddCustomerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Ajout d'un Client";
                MsgConnected.Content = "Bienvenue,";
            }
            //Édition d'un Client
            if (TitleWindow.Text == "Edite a Customer")
            {
                Body.Source = new Uri("Pages/Français/Clients/EditeCustomerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Édition d'un Client";
                MsgConnected.Content = "Bienvenue,";
            }
            //Suppression d'un Client
            if (TitleWindow.Text == "Delete a Customer")
            {
                Body.Source = new Uri("Pages/Français/Clients/DeleteCustomerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Suppression d'un Client";
                MsgConnected.Content = "Bienvenue,";
            }
            #endregion
            #region Partenaires de Diffusion
            //Gestion des Partenaires de Diffusion
            if (TitleWindow.Text == "Partners Management")
            {
                Body.Source = new Uri("Pages/Français/Partenaires/PartnerManagerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Gestion des Partenaires de Diffusion";
                MsgConnected.Content = "Bienvenue,";
            }
            //Affichage des Partenaires de Diffusion
            if (TitleWindow.Text == "Show Partners")
            {
                Body.Source = new Uri("Pages/Français/Partenaires/ShowPartnerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Affichage des Partenaires de Diffusion";
                MsgConnected.Content = "Bienvenue,";
            }
            //Ajout d'un Partenaire de Diffusion
            if (TitleWindow.Text == "Add a Partner")
            {
                Body.Source = new Uri("Pages/Français/Partenaires/AddPartnerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Ajout d'un Partenaire de Diffusion";
                MsgConnected.Content = "Bienvenue,";
            }
            //Édition d'un Partenaire de Diffusion
            if (TitleWindow.Text == "Edite a Partner")
            {
                Body.Source = new Uri("Pages/Français/Partenaires/EditePartnerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Édition d'un Partenaire de Diffusion";
                MsgConnected.Content = "Bienvenue,";
            }
            //Suppression d'un Partenaire de Diffusion
            if (TitleWindow.Text == "Delete a Partner")
            {
                Body.Source = new Uri("Pages/Français/Partenaires/DeletePartnerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Suppression d'un Partenaire de Diffusion";
                MsgConnected.Content = "Bienvenue,";
            }
            #endregion
            #region Offres de Castings
            //Gestion des Offres de Castings
            if (TitleWindow.Text == "Castings Offers Management")
            {
                Body.Source = new Uri("Pages/Français/Castings/CastingManagerFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Gestion des Offres de Castings";
                MsgConnected.Content = "Bienvenue,";
            }
            //Affichage des Offres de Castings
            if (TitleWindow.Text == "Show Castings Offers")
            {
                Body.Source = new Uri("Pages/Français/Castings/ShowCastingFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Affichage des Offres de Castings";
                MsgConnected.Content = "Bienvenue,";
            }
            //Affichage des Offres de Castings - page 2
            if (TitleWindow.Text == "Show Castings Offers - page 2")
            {
                Body.Source = new Uri("Pages/Français/Castings/ShowCasting2Fr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Affichage des Offres de Castings - page 2";
                MsgConnected.Content = "Bienvenue,";
            }
            //Ajout d'une Offre de Casting
            if (TitleWindow.Text == "Add an Casting Offer")
            {
                Body.Source = new Uri("Pages/Français/Castings/AddCastingFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Ajout d'une Offre de Casting";
                MsgConnected.Content = "Bienvenue,";
            }
            //Ajout d'une Offre de Casting - page 2
            if (TitleWindow.Text == "Add an Casting Offer - page 2")
            {
                Body.Source = new Uri("Pages/Français/Castings/AddCasting2Fr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Ajout d'une Offre de Casting - page 2";
                MsgConnected.Content = "Bienvenue,";
            }
            //Édition d'une Offre de Casting
            if (TitleWindow.Text == "Edite an Casting Offer")
            {
                Body.Source = new Uri("Pages/Français/Castings/EditeCastingFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Édition d'une Offre de Casting";
                MsgConnected.Content = "Bienvenue,";
            }
            //Édition d'une Offre de Casting - page 2
            if (TitleWindow.Text == "Edite an Casting Offer - page 2")
            {
                Body.Source = new Uri("Pages/Français/Castings/EditeCasting2Fr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Édition d'une Offre de Casting - page 2";
                MsgConnected.Content = "Bienvenue,";
            }
            //Suppression d'une Offre de Casting
            if (TitleWindow.Text == "Delete an Casting Offer")
            {
                Body.Source = new Uri("Pages/Français/Castings/DeleteCastingFr.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Suppression d'une Offre de Casting";
                MsgConnected.Content = "Bienvenue,";
            }
            #endregion
        }
        #endregion
        //-----------------------------------------------------------------
        #region Anglais
        private void EnButton_Click(object sender, RoutedEventArgs e)
        {
            FrLabel.Visibility = Visibility.Hidden;
            FrButton.Visibility = Visibility.Visible;
            EnLabel.Visibility = Visibility.Visible;
            EnButton.Visibility = Visibility.Hidden;

            //Connexion
            if (TitleWindow.Text == "Connexion")
            {
                Body.Source = new Uri("Pages/Anglais/ConnexionEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Connection";
            }

            //Accueil
            if (TitleWindow.Text == "Accueil")
            {
                Body.Source = new Uri("Pages/Anglais/AccueilEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Home";
                MsgConnected.Content = "Welcome,";
            }

            #region Clients
            //Gestion des Clients
            if (TitleWindow.Text == "Gestion des Clients")
            {
                Body.Source = new Uri("Pages/Anglais/Clients/CustomerManagerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Customers Management";
                MsgConnected.Content = "Welcome,";
            }
            //Affichage des Clients
            if (TitleWindow.Text == "Affichage des Clients")
            {
                Body.Source = new Uri("Pages/Anglais/Clients/ShowCustomerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Show Customers";
                MsgConnected.Content = "Welcome,";
            }
            //Ajout d'un Client
            if (TitleWindow.Text == "Ajout d'un Client")
            {
                Body.Source = new Uri("Pages/Anglais/Clients/AddCustomerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Add a Customer";
                MsgConnected.Content = "Welcome,";
            }
            //Édition d'un Client
            if (TitleWindow.Text == "Édition d'un Client")
            {
                Body.Source = new Uri("Pages/Anglais/Clients/EditeCustomerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Edite a Customer";
                MsgConnected.Content = "Welcome,";
            }
            //Suppression d'un Client
            if (TitleWindow.Text == "Suppression d'un Client")
            {
                Body.Source = new Uri("Pages/Anglais/Clients/DeleteCustomerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Delete a Customer";
                MsgConnected.Content = "Welcome,";
            }
            #endregion
            #region Partenaires de Diffusion
            //Gestion des Partenaires de Diffusion
            if (TitleWindow.Text == "Gestion des Partenaires de Diffusion")
            {
                Body.Source = new Uri("Pages/Anglais/Partenaires/PartnerManagerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Partners Management";
                MsgConnected.Content = "Welcome,";
            }
            //Afichage des Partenaires de Diffusion
            if (TitleWindow.Text == "Affichage des Partenaires de Diffusion")
            {
                Body.Source = new Uri("Pages/Anglais/Partenaires/ShowPartnerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Show Partners";
                MsgConnected.Content = "Welcome,";
            }
            //Ajout d'un Partenaire de Diffusion
            if (TitleWindow.Text == "Ajout d'un Partenaire de Diffusion")
            {
                Body.Source = new Uri("Pages/Anglais/Partenaires/AddPartnerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Add a Partner";
                MsgConnected.Content = "Welcome,";
            }
            //Édition d'un Partenaire de Diffusion
            if (TitleWindow.Text == "Édition d'un Partenaire de Diffusion")
            {
                Body.Source = new Uri("Pages/Anglais/Partenaires/EditePartnerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Edite a Partner";
                MsgConnected.Content = "Welcome,";
            }
            //Suppression d'un Partenaire de Diffusion
            if (TitleWindow.Text == "Suppression d'un Partenaire de Diffusion")
            {
                Body.Source = new Uri("Pages/Anglais/Partenaires/DeletePartnerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Delete a Partner";
                MsgConnected.Content = "Welcome,";
            }
            #endregion
            #region Offres de Castings
            //Gestion des Offres de Castings
            if (TitleWindow.Text == "Gestion des Offres de Castings")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/CastingManagerEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Castings Offers Management";
                MsgConnected.Content = "Welcome,";
            }
            //Affichage des Offres de Castings
            if (TitleWindow.Text == "Affichage des Offres de Castings")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/ShowCastingEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Show Castings Offers";
                MsgConnected.Content = "Welcome,";
            }
            //Affichage des Offres de Castings - page 2
            if (TitleWindow.Text == "Affichage des Offres de Castings - page 2")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/ShowCasting2En.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Show Castings Offers - page 2";
                MsgConnected.Content = "Welcome,";
            }
            //Ajout d'une Offre de Casting
            if (TitleWindow.Text == "Ajout d'une Offre de Casting")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/AddCastingEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Add an Casting Offer";
                MsgConnected.Content = "Welcome,";
            }
            //Ajout d'une Offre de Casting - page 2
            if (TitleWindow.Text == "Ajout d'une Offre de Casting - page 2")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/AddCasting2En.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Add an Casting Offer - page 2";
                MsgConnected.Content = "Welcome,";
            }
            //Édition d'une Offre de Casting
            if (TitleWindow.Text == "Édition d'une Offre de Casting")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/EditeCastingEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Edite an Casting Offer";
                MsgConnected.Content = "Welcome,";
            }
            //Édition d'une Offre de Casting - page 2
            if (TitleWindow.Text == "Édition d'une Offre de Casting - page 2")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/EditeCasting2En.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Edite an Casting Offer - page 2";
                MsgConnected.Content = "Welcome,";
            }
            //Suppression d'une Offre de Casting
            if (TitleWindow.Text == "Suppression d'une Offre de Casting")
            {
                Body.Source = new Uri("Pages/Anglais/Castings/DeleteCastingEn.xaml", UriKind.RelativeOrAbsolute);
                TitleWindow.Text = "Delete an Casting Offer";
                MsgConnected.Content = "Welcome,";
            }
            #endregion
        }
        #endregion
        #endregion
        //-----------------------------------------------------------------
        #region Déconnexion
        private void LoginOutButton_Click(object sender, RoutedEventArgs e)
        {
            //Français
            if (FrLabel.Visibility == Visibility.Visible)
            {
                Fenêtres.MessageFr messageFr = new Fenêtres.MessageFr();
                messageFr.TitleWindow.Text = "Déconnexion";
                messageFr.Top = 250;
                messageFr.Left = 300;
                messageFr.Show();
                this.Hide();
            }
            //Anglais
            if (EnLabel.Visibility == Visibility.Visible)
            {
                Fenêtres.MessageEn messageEn = new Fenêtres.MessageEn();
                messageEn.TitleWindow.Text = "Logout";
                messageEn.Top = 250;
                messageEn.Left = 300;
                messageEn.Show();
                this.Hide();
            }
        }
        #endregion
    }
}
