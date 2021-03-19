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
    
public partial class Выбор_тренера : Window
    {
        public Выбор_тренера()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Таб_ВТренера.ItemsSource = db.Kurs_Trainer.ToList();
            Choice.ItemsSource = db.Kurs_Trainer.ToList();
            
        }
        private void Button_PT(object sender, RoutedEventArgs e)
        {
            if (Choice.SelectedItem == null)
            {
                MessageBox.Show("Ключевые поля не заполнены");
            }
            else
            {
                string Cho = Convert.ToString((Choice.SelectedItem as Kurs_Trainer).IdTrainer);
                MethPZ methPZ = new MethPZ();
                methPZ.Button_App(TxtЦель.Text, Cho);
            }
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
