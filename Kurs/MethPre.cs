using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kurs
{
    public class MethPre
    {
        public bool Button_Pre(string Dat, string Pre)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_ExerciseForDay kurs_ExerciseForDay = new Kurs_ExerciseForDay();
            if (string.IsNullOrWhiteSpace(Dat) || string.IsNullOrWhiteSpace(Pre))
            {
                MessageBox.Show("Поля не заполнены");
                return false;
            }
            else
            {
                DateTime num = Convert.ToDateTime(Dat);
                var uRow = db.Kurs_ExerciseForDay.Where(w => w.Дата_тренировки == num).FirstOrDefault();
                uRow.PresenceId = Convert.ToInt32(Pre);
                db.SaveChanges();
            }
            return true;
        }
    }
}