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
    public partial class Окно_тренера : Window
    {
        public Окно_тренера()
        {
            InitializeComponent();
        }

        private void Button_Rasp(object sender, RoutedEventArgs e)
        {
            Расписание расписание = new Расписание();
            расписание.Show();
            Close();
        }

        private void Button_Request(object sender, RoutedEventArgs e)
        {
            ЗаявкиТр заявкиТр = new ЗаявкиТр();
            заявкиТр.Show();
            Close();
        }
        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Авторизация авт = new Авторизация();
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Выйти из аккаунта?", "Выход", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                авт.Show();
                Close();
            }
        }
    }
}
