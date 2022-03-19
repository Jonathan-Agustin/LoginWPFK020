using LoginWPFK020.Negocio;
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

namespace LoginWPFK020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       private LoginService login = new LoginService(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private loginButton Click(object sender, RoutedEventArgs)
        {
            string username = UsernameTextbox.Text;
            string password = passwordTextbox.Password;

            if(login.checkArchivoTexto(username, password) )
            {
                //salidaLabel.Content = "Usuairo logeado";
                MessageBox.Show("Exito!", "Usuario logeado");
            }
            else
            {
                MessageBox.Show("Error de login", "Usuario o password incorrecto");
                //salidaLabel.Content = "Usuario o password incorrectos";
            }
        }
    }

    internal class loginButton
    {
    }
}
