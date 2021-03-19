using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;

namespace Kurs
{
    public class MethRasp
    {
        public bool Button_Ins(string TxtДатаТ, string TxtУпр, string Gr, string TxtIdПТ)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_ExerciseForDay kurs_ExerciseForDay = new Kurs_ExerciseForDay();
            if (string.IsNullOrWhiteSpace(Gr) || string.IsNullOrWhiteSpace(TxtДатаТ) || string.IsNullOrWhiteSpace(TxtУпр) || string.IsNullOrWhiteSpace(TxtIdПТ))
            {
                MessageBox.Show("Ключевые поля не заполнены");
                return false;
            }
            else
            {
                kurs_ExerciseForDay.Дата_тренировки = Convert.ToDateTime(TxtДатаТ);
                kurs_ExerciseForDay.Упражнение = TxtУпр;
                kurs_ExerciseForDay.UnitId = Convert.ToInt32(Gr);
                kurs_ExerciseForDay.TrainingProgramId = Convert.ToInt32(TxtIdПТ);
                db.Kurs_ExerciseForDay.Add(kurs_ExerciseForDay);
                db.SaveChanges();
            }
            return true;
        }
        public bool Button_InsPP(string TxtДатаНПП, string TxtДатаКПП, string Gr2)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_TrainingProgram kurs_TrainingProgram = new Kurs_TrainingProgram();
            if (string.IsNullOrWhiteSpace(Gr2) || string.IsNullOrWhiteSpace(TxtДатаНПП) || string.IsNullOrWhiteSpace(TxtДатаКПП))
            {
                MessageBox.Show("Ключевые поля не заполнены");
                return false;
            }
            else
            {
                kurs_TrainingProgram.UnitId = Convert.ToInt32(Gr2);
                kurs_TrainingProgram.Дата_конца = Convert.ToDateTime(TxtДатаНПП);
                kurs_TrainingProgram.Дата_начала = Convert.ToDateTime(TxtДатаКПП);
                db.Kurs_TrainingProgram.Add(kurs_TrainingProgram);
                db.SaveChanges();
            }
            return true;
        }
        public bool Button_Del(string TxtIdRasp)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_ExerciseForDay kurs_ExerciseForDay = new Kurs_ExerciseForDay();
            Regex ruWords = new Regex("[А-Яа-я]");
            Regex engWords = new Regex("[A-Za-z]");
            if (string.IsNullOrWhiteSpace(TxtIdRasp))
            {
                MessageBox.Show("Поле не заполнено");
                return false;
            }
            else if (ruWords.IsMatch(TxtIdRasp) || engWords.IsMatch(TxtIdRasp) || Convert.ToInt32(TxtIdRasp) > kurs_ExerciseForDay.IdExerciseForDay)
            {
                MessageBox.Show("Введены неккоректные данные");
                return false;
            }
            else
            {
                int num = Convert.ToInt32(TxtIdRasp);
                var dRow = db.Kurs_ExerciseForDay.Where(w => w.IdExerciseForDay == num).FirstOrDefault();
                if (dRow == null)
                {
                    MessageBox.Show("Поле не заполнено");
                    return false;
                }
                else
                {
                    db.Kurs_ExerciseForDay.Remove(dRow);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }
}
