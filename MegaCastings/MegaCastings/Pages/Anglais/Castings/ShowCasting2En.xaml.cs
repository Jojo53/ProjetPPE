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
    /// Logique d'interaction pour ShowCasting2En.xaml
    /// </summary>
    public partial class ShowCasting2En : Page
    {
        public ShowCasting2En()
        {
            //Initialization
            InitializeComponent();
            BDD bdd = new BDD();
            bdd.ShowCasting2(ListCastings);
        }
    }
}
