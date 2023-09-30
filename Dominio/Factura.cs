namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.Detalle_Facura = new HashSet<Detalle_Facura>();
            this.Devolucion = new HashSet<Devolucion>();
        }
    
        public int id_factura { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_Usuarios { get; set; }
        public int Id_Clientes { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Facura> Detalle_Facura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion> Devolucion { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}