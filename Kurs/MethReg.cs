using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kurs
{
    public class MethReg
    {
        public bool Button_Reg(string TxtLogin, string PasPassword, string TxtФамилия, string TxtИмя, string TxtОтчество, string TxtДатаР, string TxtВозраст, string Gend, string TxtНомер)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            if (string.IsNullOrWhiteSpace(TxtLogin) || string.IsNullOrWhiteSpace(PasPassword) || string.IsNullOrWhiteSpace(TxtФамилия) || string.IsNullOrWhiteSpace(TxtИмя) || string.IsNullOrWhiteSpace(TxtДатаР) || string.IsNullOrWhiteSpace(TxtВозраст) || string.IsNullOrWhiteSpace(Gend) || string.IsNullOrWhiteSpace(TxtНомер))
            {
                MessageBox.Show("Ключевые поля не заполнены");
                return false;
            }
            else
            {
                if (db.Kurs_User.Select(item => item.Логин).Contains(TxtLogin))
                {
                    MessageBox.Show("Логин уже существует в системе");
                    return false;
                }
                Kurs_User kurs_User = new Kurs_User();
                Kurs_Client kurs_Client = new Kurs_Client();
                kurs_User.Логин = TxtLogin;
                kurs_User.Пароль = PasPassword;
                kurs_User.Фамилия = TxtФамилия;
                kurs_User.Имя = TxtИмя;
                kurs_User.Отчество = TxtОтчество;
                kurs_Client.Дата_рождения = Convert.ToDateTime(TxtДатаР);
                kurs_Client.Возраст = Convert.ToInt32(TxtВозраст);
                kurs_Client.GenderId = Convert.ToInt32(Gend);
                kurs_Client.UnitId = 1;
                kurs_User.Телефон = TxtНомер;
                kurs_User.RoleId = 3;

                db.Kurs_User.Add(kurs_User);
                db.Kurs_Client.Add(kurs_Client);
                db.SaveChanges();

                MessageBox.Show("Вы успешно зарегистрировались");
            }
            return true;
        }
    }
}