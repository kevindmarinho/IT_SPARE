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
    
    public partial class T020_CENTRO_CUSTO_APROVADOR
    {
        public long T001_IDCOLABORADOR { get; set; }
        public int T002_IDCENTROCUSTO { get; set; }
        public string T007_IDSISTEMA { get; set; }
        public System.DateTime DT_INICIO { get; set; }
        public Nullable<System.DateTime> DT_FINAL { get; set; }
        public string OBS_APROVADOR { get; set; }
    
        public virtual T001_COLABORADOR T001_COLABORADOR { get; set; }
        public virtual T002_CENTROCUSTO T002_CENTROCUSTO { get; set; }
        public virtual T007_SISTEMA T007_SISTEMA { get; set; }
    }
}
