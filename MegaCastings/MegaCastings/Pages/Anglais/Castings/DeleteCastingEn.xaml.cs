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

namespace MegaCastings.Pages.Anglais.Castings
{
    /// <summary>
    /// Logique d'interaction pour DeleteCastingEn.xaml
    /// </summary>
    public partial class DeleteCastingEn : Page
    {
        //Variables
        public static String IdSelected;

        public DeleteCastingEn()
        {
            //Initialization
            InitializeComponent();

            //Affichage
            IntituleTitle.Visibility = Visibility.Hidden;
            Intitule.Visibility = Visibility.Hidden;
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Charger la liste des Offres de Casting
        private void OnLoad(object sender, System.EventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowCastingCombobox(ListDelCastings);

        }
        #endregion
        //-----------------------------------------------------------------
        #region Selectionner l'Offre de Casting à supprimer
        private void Show_Click(object sender, RoutedEventArgs e)
        {

            IdSelected = ListDelCastings.SelectedValue.ToString();
            BDD bdd = new BDD();
            bdd.ShowCastingByIdDelete(Intitule);

            //Affichage
            IntituleTitle.Visibility = Visibility.Visible;
            Intitule.Visibility = Visibility.Visible;
        }
        #endregion
        //-----------------------------------------------------------------
        #region Supprimer l'Offre de Casting
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            BDD bdd = new BDD();
            bdd.DeleteCasting();

            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/CustomerManagerEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Castings Offers Management";
        }
        #endregion
    }
}
