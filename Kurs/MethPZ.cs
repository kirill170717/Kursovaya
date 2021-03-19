using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;

namespace Kurs
{
    public class MethPZ
    {
        public bool Button_App(string TxtЦель, string Cho)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_Request kurs_Request = new Kurs_Request();
            Regex specialSimbols = new Regex("([%]|[#]|[=]|[/]|[*]|[@]|[&]|[>]|[<]|[;]|[']|[$]|[№]|[!]|[№]|[;]|[{]|[}]|[[]|[]]|[~])");
            if (string.IsNullOrWhiteSpace(TxtЦель) || string.IsNullOrWhiteSpace(Cho))
            {
                MessageBox.Show("Ключевые поля не заполнены");
                return false;
            }
            else if (specialSimbols.IsMatch(TxtЦель))
            {
                MessageBox.Show("Введены некорректные данные");
                return false;
            }
            else
            {
                kurs_Request.ClientId = Idd.ClientI;
                kurs_Request.TrainerId = Convert.ToInt32(Cho);
                kurs_Request.Дата_создания_заявки = DateTime.Now;
                kurs_Request.Цель = TxtЦель;
                db.Kurs_Request.Add(kurs_Request);
                db.SaveChanges();
                MessageBox.Show("Заявка подана");
            }
            return true;
        }
    }
}
