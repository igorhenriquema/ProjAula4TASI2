//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjAula4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cidade2
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int idEstado { get; set; }
    
        public virtual Estado Estado { get; set; }
    }
}
