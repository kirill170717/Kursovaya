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
    public partial class Заявки : Window
    {
        gr691_tkpEntities db = new gr691_tkpEntities();
        public Заявки()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Таб_Заявки.ItemsSource = db.Kurs_Request.ToList();
        }
        private void Button_Del(object sender, RoutedEventArgs e)
        {
            MethReq methReq = new MethReq();
            methReq.Button_Del(TxtIdRequest.Text);
            Таб_Заявки.ItemsSource = db.Kurs_Request.ToList();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Окно_администратора ок_ад = new Окно_администратора();
            ок_ад.Show();
            Close();
        }
    }
}
