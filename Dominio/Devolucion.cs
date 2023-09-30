

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Devolucion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Devolucion()
        {
            this.DetalleDevolucion = new HashSet<DetalleDevolucion>();
        }
    
        public int iddevoluciones { get; set; }
        public Nullable<int> id_factura { get; set; }
        public Nullable<System.DateTime> fechadevolucion { get; set; }
        public Nullable<decimal> totaldevolucion { get; set; }
        public Nullable<int> Id_Usuarios { get; set; }
        public Nullable<int> Id_Clientes { get; set; }
        public string motivosdevolucion { get; set; }
        public string acciontomadas { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleDevolucion> DetalleDevolucion { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
