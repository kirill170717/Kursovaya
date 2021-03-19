using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;

namespace Kurs
{
    public class MethCli
    {
        public bool Button_Del(string TxtIdUser)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Regex ruWords = new Regex("[А-Яа-я]");
            Regex engWords = new Regex("[A-Za-z]");
            Regex specialSimbols = new Regex("([%]|[#]|[=]|[/]|[*]|[@]|[&]|[>]|[<]|[;]|[']|[$]|[№]|[!]|[№]|[;]|[{]|[}]|[[]|[]]|[~])");
            if (string.IsNullOrWhiteSpace(TxtIdUser))
            {
                MessageBox.Show("Поле не заполнено");
                return false;
            }
            else if (ruWords.IsMatch(TxtIdUser) || engWords.IsMatch(TxtIdUser) || specialSimbols.IsMatch(TxtIdUser))
            {
                MessageBox.Show("Введены некорректные данные");
                return false;
            }
            else
            {
                int num = Convert.ToInt32(TxtIdUser);
                var dRow1 = db.Kurs_Client.Where(w => w.UserId == num).FirstOrDefault();
                var dRow2 = db.Kurs_User.Where(w => w.IdUser == num).FirstOrDefault();
                db.Kurs_Client.Remove(dRow1);
                db.Kurs_User.Remove(dRow2);
                db.SaveChanges();
            }
            return true;
        }
    }
}
