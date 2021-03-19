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

namespace Kurs
{
    public partial class Авторизация : Window
    {
        public Авторизация()
        {
            InitializeComponent();
        }
        private void Button_Auth(object sender, RoutedEventArgs e)
        {
            MethAuth methAuth = new MethAuth();
            methAuth.Button_Auth(TxtLogin.Text, PasPassword.Password);
            Close();
        }
        private void Button_Reg(object sender, RoutedEventArgs e)
        {
            Регистрация рег = new Регистрация();
            рег.Show();
            Close();
        }
    }
}