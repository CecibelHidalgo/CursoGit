//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TareaTICurso1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DCBanco
    {
        public int IdBanco { get; set; }
        public Nullable<decimal> TasaInteres { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public string UsuarioInserto { get; set; }
        public Nullable<System.DateTime> FechaInserto { get; set; }
        public string UsuarioModifico { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
    
        public virtual DCCarro DCCarro { get; set; }
    }
}
