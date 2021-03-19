using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;

namespace Kurs
{
    public class MethReq
    {
        public bool Button_Del(string TxtIdRequest)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_Request kurs_Request = new Kurs_Request();
            Regex ruWords = new Regex("[А-Яа-я]");
            Regex specialSimbols = new Regex("([%]|[#]|[=]|[/]|[*]|[@]|[&]|[>]|[<]|[;]|[']|[$]|[№]|[!]|[№]|[;]|[{]|[}]|[[]|[]]|[~])");
            if (string.IsNullOrWhiteSpace(TxtIdRequest))
            {
                MessageBox.Show("Поле не заполнено");
                return false;
            }
            else if (ruWords.IsMatch(TxtIdRequest) || specialSimbols.IsMatch(TxtIdRequest) || Convert.ToInt32(TxtIdRequest) > kurs_Request.IdRequest)
            {
                MessageBox.Show("Введены некорректные данные");
                return false;
            }
            else
            {
                int num = Convert.ToInt32(TxtIdRequest);
                var dRow = db.Kurs_Request.Where(w => w.IdRequest == num).FirstOrDefault();
                if (dRow == null)
                {
                    MessageBox.Show("Поле не заполнено");
                    return false;
                }
                else
                {
                    db.Kurs_Request.Remove(dRow);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }
}
