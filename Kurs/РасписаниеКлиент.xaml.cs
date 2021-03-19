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
    public partial class РасписаниеКлиент : Window
    {
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Таб_РасписаниеКлиент.ItemsSource = db.Kurs_ExerciseForDay.Where(i => i.UnitId == Idd.UnitI).ToList();
            Pres.ItemsSource = db.Kurs_Presence.ToList();
            Date.ItemsSource = db.Kurs_ExerciseForDay.Where(i => i.UnitId == Idd.UnitI).ToList();
        }
        public РасписаниеКлиент()
        {
            InitializeComponent();
        }
        private void Button_Pre(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            if (Pres.SelectedItem == null || Date.SelectedItem == null)
            {
                MessageBox.Show("Ключевые поля не заполнены");
            }
            else
            {
                string Pre = Convert.ToString((Pres.SelectedItem as Kurs_Presence).IdPresence);
                string Dat = Convert.ToString((Date.SelectedItem as Kurs_ExerciseForDay).Дата_тренировки);
                MethPre methPre = new MethPre();
                methPre.Button_Pre(Dat, Pre);
                Таб_РасписаниеКлиент.ItemsSource = db.Kurs_ExerciseForDay.Where(i => i.UnitId == Idd.UnitI).ToList();
            }
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            АвтКлиент автКлиент = new АвтКлиент();
            автКлиент.Show();
            Close();
        }
    }
}
