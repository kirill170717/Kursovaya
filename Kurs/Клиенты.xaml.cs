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
    public partial class Клиенты : Window
    {
        gr691_tkpEntities db = new gr691_tkpEntities();
        public Клиенты()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Таб_Клиенты.ItemsSource = db.Kurs_Client.ToList();
            Таб_Пользователи.ItemsSource = db.Kurs_User.Where(a => a.RoleId == 3).ToList();
        }
        private void Button_Del(object sender, RoutedEventArgs e)
        {
            MethCli methCli = new MethCli();
            methCli.Button_Del(TxtIdUser.Text);
            Таб_Клиенты.ItemsSource = db.Kurs_Client.ToList();
            Таб_Пользователи.ItemsSource = db.Kurs_User.Where(a => a.RoleId == 3).ToList();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Окно_администратора ок_ад = new Окно_администратора();
            ок_ад.Show();
            Close();
        }
    }
}
