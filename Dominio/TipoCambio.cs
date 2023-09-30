namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoCambio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoCambio()
        {
            this.Detalle_Facura = new HashSet<Detalle_Facura>();
        }
    
        public int IDTipoCambio { get; set; }
        public Nullable<decimal> PrecioCambio { get; set; }
        public Nullable<System.DateTime> FechaC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Facura> Detalle_Facura { get; set; }
    }
}