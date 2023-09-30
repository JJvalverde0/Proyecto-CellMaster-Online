namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proveedores : Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedores()
        {
            this.Compras = new HashSet<Compras>();
        }
    
        public string Nombre_Empresa { get; set; }
        public string Departamento { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compras> Compras { get; set; }
    }
}
