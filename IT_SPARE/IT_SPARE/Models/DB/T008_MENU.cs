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
    
    public partial class T008_MENU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T008_MENU()
        {
            this.T009_PERFIL = new HashSet<T009_PERFIL>();
        }
    
        public string T007_IDSISTEMA { get; set; }
        public string T008_IDMENU { get; set; }
        public string T008_DESCRICAO { get; set; }
    
        public virtual T007_SISTEMA T007_SISTEMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T009_PERFIL> T009_PERFIL { get; set; }
    }
}
