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
    
    public partial class Kurs_Presence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kurs_Presence()
        {
            this.Kurs_ExerciseForDay = new HashSet<Kurs_ExerciseForDay>();
        }
    
        public int IdPresence { get; set; }
        public string Присутствие { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kurs_ExerciseForDay> Kurs_ExerciseForDay { get; set; }
    }
}
