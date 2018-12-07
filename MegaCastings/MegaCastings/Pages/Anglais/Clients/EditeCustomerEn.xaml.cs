﻿using MegaCastings.bdd;
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

namespace MegaCastings.Pages.Anglais.Clients
{
    /// <summary>
    /// Logique d'interaction pour EditeCustomerEn.xaml
    /// </summary>
    public partial class EditeCustomerEn : Page
    {
        //Variables
        public static String IdSelected;

        public EditeCustomerEn()
        {
            //Initialization
            InitializeComponent();

            //Affichage
            NomTitle.Visibility = Visibility.Hidden;
            Nom.Visibility = Visibility.Hidden;
            PrenomTitle.Visibility = Visibility.Hidden;
            Prenom.Visibility = Visibility.Hidden;
            MailTitle.Visibility = Visibility.Hidden;
            Mail.Visibility = Visibility.Hidden;
            PasswordTitle.Visibility = Visibility.Hidden;
            Password.Visibility = Visibility.Hidden;
            RoleTitle.Visibility = Visibility.Hidden;
            Role.Visibility = Visibility.Hidden;
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Charger la liste des Clients
        private void OnLoad(object sender, System.EventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowCustomerCombobox(ListUpdCustomers);

        }
        #endregion
        //-----------------------------------------------------------------
        #region Selectionner un Client à modifier
        private void Show_Click(object sender, RoutedEventArgs e)
        {
            IdSelected = ListUpdCustomers.SelectedValue.ToString();

            //Affichage
            NomTitle.Visibility = Visibility.Visible;
            Nom.Visibility = Visibility.Visible;
            PrenomTitle.Visibility = Visibility.Visible;
            Prenom.Visibility = Visibility.Visible;
            MailTitle.Visibility = Visibility.Visible;
            Mail.Visibility = Visibility.Visible;
            PasswordTitle.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Visible;
            RoleTitle.Visibility = Visibility.Visible;
            Role.Visibility = Visibility.Visible;
        }
        #endregion
        //-----------------------------------------------------------------
        #region Modifier le Client
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.UpdateCustomer(Nom, Prenom, Mail, Password, Role);

            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Clients/CustomerManagerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Customers Management";
        }
        #endregion
    }
}