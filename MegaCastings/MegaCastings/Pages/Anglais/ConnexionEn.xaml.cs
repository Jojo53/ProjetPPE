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

namespace MegaCastings.Pages.Anglais
{
    /// <summary>
    /// Logique d'interaction pour ConnexionEn.xaml
    /// </summary>
    public partial class ConnexionEn : Page
    {
        public ConnexionEn()
        {
            //Initialization
            InitializeComponent();
            SignInError.Visibility = Visibility.Hidden;
        }

        //-----------------------------------------------------------------
        //-----------------------------------------------------------------
        //Contenu
        #region Appuyer sur Entrée pour se connecter
        public void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (LoginBox.Text == "root" && PasswordBox.Password == "Not24get")
                {
                    var mainwindow = Application.Current.MainWindow as MainWindow;
                    Thickness NavigationThickness = new Thickness();
                    NavigationThickness.Left = 75;

                    mainwindow.Body.Source = new Uri("Pages/Anglais/AccueilEn.xaml", UriKind.RelativeOrAbsolute);
                    mainwindow.TitleWindow.Text = "Home";
                    mainwindow.LoginOutButton.Visibility = Visibility.Visible;
                    mainwindow.Connected.Visibility = Visibility.Visible;
                    mainwindow.Navigation.Margin = NavigationThickness;
                    mainwindow.MsgConnected.Content = "Welcome,";
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

                mainwindow.Body.Source = new Uri("Pages/Anglais/AccueilEn.xaml", UriKind.RelativeOrAbsolute);
                mainwindow.TitleWindow.Text = "Home";
                mainwindow.LoginOutButton.Visibility = Visibility.Visible;
                mainwindow.Connected.Visibility = Visibility.Visible;
                mainwindow.Navigation.Margin = NavigationThickness;
                mainwindow.MsgConnected.Content = "Welcome,";
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
