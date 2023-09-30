namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios : Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Compras = new HashSet<Compras>();
            this.Devolucion = new HashSet<Devolucion>();
            this.Factura = new HashSet<Factura>();
        }
    
        public string Cargo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compras> Compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion> Devolucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
    }
}