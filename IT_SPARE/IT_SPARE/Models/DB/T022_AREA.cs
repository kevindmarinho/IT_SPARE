//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IT_SPARE.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class T022_AREA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T022_AREA()
        {
            this.T023_AREA_COLABORADOR = new HashSet<T023_AREA_COLABORADOR>();
        }
    
        public int T022_IDAREA { get; set; }
        public string T022_DESCRICAO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T023_AREA_COLABORADOR> T023_AREA_COLABORADOR { get; set; }
    }
}
