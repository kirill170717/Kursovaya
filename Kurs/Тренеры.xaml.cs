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
    public partial class Тренеры : Window
    {
        gr691_tkpEntities db = new gr691_tkpEntities();
        public Тренеры()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Таб_Тренеры.ItemsSource = db.Kurs_Trainer.ToList();
            Таб_Пользователи.ItemsSource = db.Kurs_User.Where(a => a.RoleId == 2).ToList();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Окно_администратора ок_ад = new Окно_администратора();
            ок_ад.Show();
            Close();
        }
        private void Button_Ins(object sender, RoutedEventArgs e)
        {
            MethTrain methTrain = new MethTrain();
            methTrain.Button_Ins(TxtДостиж.Text, TxtОпыт.Text, TxtЛогин.Text, TxtПароль.Text, TxtФамилия.Text, TxtИмя.Text, TxtОтчество.Text, TxtНомер.Text);
            Таб_Тренеры.ItemsSource = db.Kurs_Trainer.ToList();
            Таб_Пользователи.ItemsSource = db.Kurs_User.Where(a => a.RoleId == 2).ToList();
        }
        private void Button_Del(object sender, RoutedEventArgs e)
        {
            MethTrain methTrain = new MethTrain();
            methTrain.Button_Del(TxtIdUser.Text);
            Таб_Тренеры.ItemsSource = db.Kurs_Trainer.ToList();
            Таб_Пользователи.ItemsSource = db.Kurs_User.Where(a => a.RoleId == 2).ToList();
        }
    }
}