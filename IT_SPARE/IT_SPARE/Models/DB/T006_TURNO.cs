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
    
    public partial class T006_TURNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T006_TURNO()
        {
            this.T001_COLABORADOR = new HashSet<T001_COLABORADOR>();
        }
    
        public int T006_IDTURNO { get; set; }
        public int T006_NUMERO { get; set; }
        public string T006_DESCRICAO { get; set; }
        public Nullable<bool> T006_MUDA_DIA { get; set; }
        public Nullable<System.TimeSpan> T006_HORAENTRADA { get; set; }
        public Nullable<System.TimeSpan> T006_HORASAIDA { get; set; }
        public Nullable<System.TimeSpan> T006_HORALIMITETURNO { get; set; }
        public Nullable<System.TimeSpan> T006_TOLERANCIAHORAENTRADA { get; set; }
        public Nullable<System.TimeSpan> T006_TOLERANCIAHORASAIDA { get; set; }
        public Nullable<System.TimeSpan> T006_HORAENTRADAREFEICAO { get; set; }
        public Nullable<System.TimeSpan> T006_HORASAIDAREFEICAO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T001_COLABORADOR> T001_COLABORADOR { get; set; }
    }
}
