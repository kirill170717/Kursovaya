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
    public partial class Окно_администратора : Window
    {
        public Окно_администратора()
        {
            InitializeComponent();
        }
        private void Button_Trainers(object sender, RoutedEventArgs e)
        {
            Тренеры тренеры = new Тренеры();
            тренеры.Show();
            Close();
        }

        private void Button_Client(object sender, RoutedEventArgs e)
        {
            Клиенты клиенты = new Клиенты();
            клиенты.Show();
            Close();
        }

        private void Button_Request(object sender, RoutedEventArgs e)
        {
            Заявки заявки = new Заявки();
            заявки.Show();
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
