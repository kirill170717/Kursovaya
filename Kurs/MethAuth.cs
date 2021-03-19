using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kurs
{
    class Idd
    {
        public static int ClientI = 0;
        public static int TrainerI = 0;
        public static int UnitI = 0;
    }
    public class MethAuth
    {
        public bool Button_Auth(string TxtLogin, string PasPassword)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Окно_администратора ок_ад = new Окно_администратора();
            Окно_тренера ок_тр = new Окно_тренера();
            Выбор_тренера выбор_Тренера = new Выбор_тренера();
            АвтКлиент автКлиент = new АвтКлиент();
            Kurs_User kurs_User = db.Kurs_User.FirstOrDefault(i => i.Логин == TxtLogin);
            if (string.IsNullOrWhiteSpace(TxtLogin) || string.IsNullOrWhiteSpace(PasPassword))
            {
                MessageBox.Show("Ключевые поля не заполнены");
                return false;
            }
            else if (kurs_User != null)
            {
                if (kurs_User.Логин == TxtLogin && kurs_User.Пароль == PasPassword)
                {
                    if (kurs_User.RoleId == 1)
                    {
                        ок_ад.Show();
                    }
                    else if (kurs_User.RoleId == 2)
                    {
                        Idd.TrainerI = db.Kurs_Trainer.FirstOrDefault(i => i.Kurs_User.Логин == TxtLogin).IdTrainer;
                        ок_тр.Show();
                    }
                    else if (kurs_User.RoleId == 3)
                    {
                        Idd.ClientI = db.Kurs_Client.FirstOrDefault(i => i.Kurs_User.Логин == TxtLogin).IdClient;
                        Idd.UnitI = db.Kurs_Client.FirstOrDefault(i => i.Kurs_User.Логин == TxtLogin).UnitId;
                        if (Idd.UnitI == 1)
                        {
                            выбор_Тренера.Show();
                        }
                        else
                        {
                            автКлиент.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует");
                return false;
            }
            return true;
        }
    }
}