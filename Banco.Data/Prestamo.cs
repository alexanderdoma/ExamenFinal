//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banco.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prestamo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prestamo()
        {
            this.DetallePrestamo = new HashSet<DetallePrestamo>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<int> Cuotas { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePrestamo> DetallePrestamo { get; set; }
    }
}
