//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HabitTracker.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diplom_Habit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diplom_Habit()
        {
            this.Diplom_Users_Habit = new HashSet<Diplom_Users_Habit>();
        }
    
        public string ID_Habit { get; set; }
        public string Name { get; set; }
        public Nullable<int> Type_habit { get; set; }
    
        public virtual Diplom_Type_habit Diplom_Type_habit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diplom_Users_Habit> Diplom_Users_Habit { get; set; }
    }
}
