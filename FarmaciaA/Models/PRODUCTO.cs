//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmaciaA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.SUCURSAL_PRODUCTO = new HashSet<SUCURSAL_PRODUCTO>();
        }
    
        public int ID_PRODUCTO { get; set; }
        public Nullable<int> ID_PRESENTACION { get; set; }
        public Nullable<int> ID_CATEGORIA { get; set; }
        public Nullable<int> ID_LABORATORIO { get; set; }
        public string PRODUCTO1 { get; set; }
        public string DESCRIPCION { get; set; }
        public byte[] IMAGEN_PRODUCTO { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual LABORATORIO LABORATORIO { get; set; }
        public virtual PRESENTACION PRESENTACION { get; set; }
        public virtual ICollection<SUCURSAL_PRODUCTO> SUCURSAL_PRODUCTO { get; set; }
    }
}
