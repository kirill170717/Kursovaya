using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kurs
{
    public class MethTrain
    {
        public bool Button_Ins(string TxtДостиж, string TxtОпыт, string TxtЛогин, string TxtПароль, string TxtФамилия, string TxtИмя, string TxtОтчество, string TxtНомер)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_Trainer kurs_Trainer = new Kurs_Trainer();
            Kurs_User kurs_User = new Kurs_User();
            if (string.IsNullOrWhiteSpace(TxtДостиж) || string.IsNullOrWhiteSpace(TxtОпыт) || string.IsNullOrWhiteSpace(TxtЛогин) || string.IsNullOrWhiteSpace(TxtПароль) || string.IsNullOrWhiteSpace(TxtФамилия) || string.IsNullOrWhiteSpace(TxtИмя) || string.IsNullOrWhiteSpace(TxtНомер))
            {
                MessageBox.Show("Ключевые поля не заполнены");
                return false;
            }
            else if (db.Kurs_User.Select(item => item.Логин).Contains(TxtЛогин))
            {
                MessageBox.Show("Логин уже существует в системе");
                return false;
            }
            else
            {
                kurs_Trainer.Достижения = TxtДостиж;
                kurs_Trainer.Опыт_работы = TxtОпыт;
                kurs_User.Логин = TxtЛогин;
                kurs_User.Пароль = TxtПароль;
                kurs_User.Фамилия = TxtФамилия;
                kurs_User.Имя = TxtИмя;
                kurs_User.Отчество = TxtОтчество;
                kurs_User.Телефон = TxtНомер;
                kurs_User.RoleId = 2;
                db.Kurs_User.Add(kurs_User);
                db.Kurs_Trainer.Add(kurs_Trainer);
                db.SaveChanges();
            }
            return true;
        }
        public bool Button_Del(string TxtIdUser)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            if (string.IsNullOrWhiteSpace(TxtIdUser))
            {
                MessageBox.Show("Поле не заполнено");
                return false;
            }
            else
            {
                int num = Convert.ToInt32(TxtIdUser);
                var dRow1 = db.Kurs_Trainer.Where(w => w.UserId == num).FirstOrDefault();
                var dRow2 = db.Kurs_User.Where(w => w.IdUser == num).FirstOrDefault();
                db.Kurs_Trainer.Remove(dRow1);
                db.Kurs_User.Remove(dRow2);
                db.SaveChanges();
            }
            return true;
        }
    }
}
