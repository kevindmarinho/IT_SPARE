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
    
    public partial class T012_GRUPO_EMAIL
    {
        public int T011_IDGRUPO { get; set; }
        public string T012_EMAIL { get; set; }
    
        public virtual T011_GRUPO T011_GRUPO { get; set; }
    }
}
