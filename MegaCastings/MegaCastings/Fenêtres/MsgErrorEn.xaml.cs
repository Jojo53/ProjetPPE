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
using System.Windows.Shapes;

namespace MegaCastings.Fenêtres
{
    /// <summary>
    /// Logique d'interaction pour MsgErrorEn.xaml
    /// </summary>
    public partial class MsgErrorEn : Window
    {
        public MsgErrorEn()
        {
            //Initialization
            InitializeComponent();
        }
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
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Show();
            this.Close();
        }
        #endregion
        #endregion
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Valider
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Show();
            this.Close();
        }
        #endregion
    }
}
