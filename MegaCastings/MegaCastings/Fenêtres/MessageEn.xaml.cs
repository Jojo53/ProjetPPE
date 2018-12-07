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
    /// Logique d'interaction pour MessageEn.xaml
    /// </summary>
    public partial class MessageEn : Window
    {
        public MessageEn()
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
        #region Se déconnecter
        private void ValidButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            Thickness NavigationThickness = new Thickness();
            NavigationThickness.Left = 105;
            mainwindow.Body.Source = new Uri("Pages/Anglais/ConnexionEn.xaml", UriKind.RelativeOrAbsolute);
            mainwindow.LoginOutButton.Visibility = Visibility.Hidden;
            mainwindow.BackButton.Visibility = Visibility.Hidden;
            mainwindow.Connected.Visibility = Visibility.Hidden;
            mainwindow.MsgConnected.Content = "";
            mainwindow.UserConnected.Content = "";
            mainwindow.TitleWindow.Text = "Connexion";
            mainwindow.Show();
            this.Close();
        }
        #endregion
        //-----------------------------------------------------------------
        #region Ne pas se déconnecter
        private void UnValidButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.Show();
            this.Close();
        }
        #endregion
    }
}
