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
    /// Logique d'interaction pour ShowCasting2Fr.xaml
    /// </summary>
    public partial class ShowCasting2Fr : Page
    {
        public ShowCasting2Fr()
        {
            //Initialization
            InitializeComponent();
            BDD bdd = new BDD();
            bdd.ShowCasting2(ListCastings);
        }
    }
}
