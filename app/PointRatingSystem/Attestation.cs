//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointRatingSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attestation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attestation()
        {
            this.Students1 = new HashSet<Students>();
        }
    
        public int ID { get; set; }
        public int Student_ID { get; set; }
        public int Subjet_ID { get; set; }
        public int Score { get; set; }
    
        public virtual Students Students { get; set; }
        public virtual Subjects Subjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students1 { get; set; }
    }
}