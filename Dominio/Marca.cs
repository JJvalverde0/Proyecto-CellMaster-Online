namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Marca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Marca()
        {
            this.Producto = new HashSet<Producto>();
        }
    
        public int Id_Marca { get; set; }
        public string Nombre_Marca { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}