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
    public partial class Расписание : Window
    {
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Таб_Расписание.ItemsSource = db.Kurs_ExerciseForDay.ToList();
            Таб_ПрогТрен.ItemsSource = db.Kurs_TrainingProgram.ToList();
        }
        public Расписание()
        {
            InitializeComponent();
            gr691_tkpEntities db = new gr691_tkpEntities();
            Group.ItemsSource = db.Kurs_Unit.ToList();
            Group2.ItemsSource = db.Kurs_Unit.ToList();
        }
        private void Button_Ins(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            MethRasp methRasp = new MethRasp();
            if (Group.SelectedItem == null)
            {
                MessageBox.Show("Ключевые поля не заполнены");
            }
            else
            {
                string Gr = Convert.ToString((Group.SelectedItem as Kurs_Unit).IdUnit);
                methRasp.Button_Ins(TxtДатаТ.Text, TxtУпр.Text, Gr, TxtIdПТ.Text);
                Таб_Расписание.ItemsSource = db.Kurs_ExerciseForDay.ToList();
                Таб_ПрогТрен.ItemsSource = db.Kurs_TrainingProgram.ToList();
            }
        }
        private void Button_InsPP(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            MethRasp methRasp = new MethRasp();
            if (Group2.SelectedItem == null)
            {
                MessageBox.Show("Ключевые поля не заполнены");
            }
            else
            {
                string Gr2 = Convert.ToString((Group2.SelectedItem as Kurs_Unit).IdUnit);
                methRasp.Button_InsPP(TxtДатаНПП.Text, TxtДатаКПП.Text, Gr2);
                Таб_Расписание.ItemsSource = db.Kurs_ExerciseForDay.ToList();
                Таб_ПрогТрен.ItemsSource = db.Kurs_TrainingProgram.ToList();
            }
        }
        private void Button_Del(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            MethRasp methRasp = new MethRasp();
            methRasp.Button_Del(TxtIdRasp.Text);
            Таб_Расписание.ItemsSource = db.Kurs_ExerciseForDay.ToList();
            Таб_ПрогТрен.ItemsSource = db.Kurs_TrainingProgram.ToList();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Окно_тренера ок_тр = new Окно_тренера();
            ок_тр.Show();
            Close();
        }
    }
}
