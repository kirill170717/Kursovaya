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

    public partial class ЗаявкиТр : Window
    {
        public ЗаявкиТр()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Таб_ЗаявкиТр.ItemsSource = db.Kurs_Request.Where(i => i.TrainerId == Idd.TrainerI).ToList();
            Accept.ItemsSource = db.Kurs_Accept.ToList();
            Unit.ItemsSource = db.Kurs_Unit.ToList();
        }
        private void Button_Upd(object sender, RoutedEventArgs e)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            MethZTr methZTr = new MethZTr();
            if (Accept.SelectedItem == null || Unit.SelectedItem == null)
            {
                MessageBox.Show("Ключевые поля не заполнены");
            }
            else
            {
                int Acc = (Accept.SelectedItem as Kurs_Accept).IdAccept;
                int Un = (Unit.SelectedItem as Kurs_Unit).IdUnit;
                methZTr.Button_Upd(TxtIdReq.Text, TxtComm.Text, Acc, Un);
                Таб_ЗаявкиТр.ItemsSource = db.Kurs_Request.ToList();
            }
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Окно_тренера ок_тр = new Окно_тренера();
            ок_тр.Show();
            Close();
        }
    }
}
