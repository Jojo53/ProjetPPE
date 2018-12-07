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
    /// Logique d'interaction pour AddCastingFr.xaml
    /// </summary>
    public partial class AddCastingFr : Page
    {
        //Variables
        public static String IntitituleVar;
        public static String DateDebutPubliacationVar;
        public static int DureeDiffusionVar;
        public static String DateDebutContratVar;
        public static String LocalisationVar;

        public AddCastingFr()
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
            DateDebutPubliacationVar = StartPubBox.DisplayDate.ToString() ;
            DureeDiffusionVar = Int32.Parse(DureeDiffusBox.Text);
            DateDebutContratVar = DateDebutContratBox.DisplayDate.ToString();
            LocalisationVar = LocalisationBox.Text;

            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Body.Source = new Uri("Pages/Français/Castings/AddCasting2Fr.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.TitleWindow.Text = "Ajout d'une Offre de Casting - page 2";
        }
        #endregion
    }
}
