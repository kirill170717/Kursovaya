using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kurs
{
    public class MethZTr
    {
        public bool Button_Upd(string TxtIdReq, string TxtComm, int Acc, int Un)
        {
            gr691_tkpEntities db = new gr691_tkpEntities();
            Kurs_Client kurs_Client = new Kurs_Client();
            if (string.IsNullOrWhiteSpace(TxtIdReq))
            {
                MessageBox.Show("Ключевые поля не заполнены");
                return false;
            }
            else
            {
                int num = Convert.ToInt32(TxtIdReq);
                var uRow1 = db.Kurs_Request.Where(w => w.IdRequest == num).FirstOrDefault();
                var uRow2 = db.Kurs_Client.Where(w => w.IdClient == num).FirstOrDefault();
                uRow1.AcceptId = Acc;
                uRow2.UnitId = Un;
                uRow1.Комментарий = TxtComm;
                uRow1.Дата_ответа = DateTime.Now;
                db.SaveChanges();
            }
            return true;
        }
    }
}
