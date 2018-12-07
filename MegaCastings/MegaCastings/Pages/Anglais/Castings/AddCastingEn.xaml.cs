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
    /// Logique d'interaction pour AddCastingEn.xaml
    /// </summary>
    public partial class AddCastingEn : Page
    {
        //Variables
        public static String IntitituleVar;
        public static String DateDebutPubliacationVar;
        public static int DureeDiffusionVar;
        public static String DateDebutContratVar;
        public static String LocalisationVar;

        public AddCastingEn()
        {
            //Initialization
            InitializeComponent();
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Bouton Suivant
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            //Variables
            IntitituleVar = IntituleBox.Text;
            DateDebutPubliacationVar = StartPubBox.DisplayDate.ToString();
            DureeDiffusionVar = Int32.Parse(DureeDiffusBox.Text);
            DateDebutContratVar = DateDebutContratBox.DisplayDate.ToString();
            LocalisationVar = LocalisationBox.Text;

            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Anglais/Castings/AddCasting2En.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Add an Casting Offer - page 2";
        }
        #endregion
    }
}
