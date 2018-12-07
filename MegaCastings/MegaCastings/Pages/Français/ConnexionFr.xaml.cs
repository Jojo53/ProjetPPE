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

namespace MegaCastings.Pages.Français
{
    /// <summary>
    /// Logique d'interaction pour ConnexionFr.xaml
    /// </summary>
    public partial class ConnexionFr : Page
    {
        public ConnexionFr()
        {
            //Initialization
            InitializeComponent();
            SignInError.Visibility = Visibility.Hidden;
        }
        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Touche Entrée pour se connecter
        public void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (LoginBox.Text == "root" && PasswordBox.Password == "Not24get")
                {
                    var mainwindow = Application.Current.MainWindow as MainWindow;
                    Thickness NavigationThickness = new Thickness();
                    NavigationThickness.Left = 75;

                    mainwindow.Body.Source = new Uri("Pages/Français/AccueilFr.xaml", UriKind.RelativeOrAbsolute);
                    mainwindow.TitleWindow.Text = "Accueil";
                    mainwindow.LoginOutButton.Visibility = Visibility.Visible;
                    mainwindow.Connected.Visibility = Visibility.Visible;
                    mainwindow.Navigation.Margin = NavigationThickness;
                    mainwindow.MsgConnected.Content = "Bienvenue,";
                    mainwindow.UserConnected.Content = LoginBox.Text;
                }
                else
                {
                    LoginBox.Text = "";
                    PasswordBox.Password = "";
                    SignInError.Visibility = Visibility.Visible;
                }
            }
        }
        #endregion
        //-----------------------------------------------------------------
        #region Bouton pour se connecter
        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == "root" && PasswordBox.Password == "Not24get")
            {
                var mainwindow = Application.Current.MainWindow as MainWindow;
                Thickness NavigationThickness = new Thickness();
                NavigationThickness.Left = 75;

                mainwindow.Body.Source = new Uri("Pages/Français/AccueilFr.xaml", UriKind.RelativeOrAbsolute);
                mainwindow.TitleWindow.Text = "Accueil";
                mainwindow.LoginOutButton.Visibility = Visibility.Visible;
                mainwindow.Connected.Visibility = Visibility.Visible;
                mainwindow.Navigation.Margin = NavigationThickness;
                mainwindow.MsgConnected.Content = "Bienvenue,";
                mainwindow.UserConnected.Content = LoginBox.Text;
            }
            else
            {
                LoginBox.Text = "";
                PasswordBox.Password = "";
                SignInError.Visibility = Visibility.Visible;
            }
        }
        #endregion
    }
}
