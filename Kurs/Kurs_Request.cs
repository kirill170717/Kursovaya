//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kurs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kurs_Request
    {
        public int IdRequest { get; set; }
        public int ClientId { get; set; }
        public int TrainerId { get; set; }
        public System.DateTime Дата_создания_заявки { get; set; }
        public string Цель { get; set; }
        public Nullable<int> AcceptId { get; set; }
        public string Комментарий { get; set; }
        public Nullable<System.DateTime> Дата_ответа { get; set; }
    
        public virtual Kurs_Accept Kurs_Accept { get; set; }
        public virtual Kurs_Client Kurs_Client { get; set; }
        public virtual Kurs_Trainer Kurs_Trainer { get; set; }
    }
}