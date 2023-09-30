namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compras()
        {
            this.Detalle_Compra = new HashSet<Detalle_Compra>();
        }
    
        public int Id_Compras { get; set; }
        public System.DateTime Fecha_Compra { get; set; }
        public int Id_Usuarios { get; set; }
        public int Id_Proveedores { get; set; }
    
        public virtual Proveedores Proveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}