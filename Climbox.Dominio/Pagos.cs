//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Climbox.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagos
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public decimal Valor { get; set; }
        public string Descripción { get; set; }
        public int Cantidad { get; set; }
        public int IdTipoFormaPago { get; set; }
        public System.DateTime FechaPago { get; set; }
        public Nullable<int> IdImpuestos { get; set; }
        public int IdTipoServicio { get; set; }
    
        public virtual TipoFormaPago TipoFormaPago { get; set; }
        public virtual TipoServicio TipoServicio { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
