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
    public partial class ЗаявкиКл : Window
    {
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Таб_Заявки.ItemsSource = db.Kurs_Request.Where(i => i.ClientId == Idd.ClientI).ToList();
        }
        public ЗаявкиКл()
        {
            InitializeComponent();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            АвтКлиент автКлиент = new АвтКлиент();
            автКлиент.Show();
            Close();
        }
    }
}
