namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleDevolucion
    {
        public int iddetalledevolucion { get; set; }
        public Nullable<int> iddevoluciones { get; set; }
        public Nullable<int> Id_Producto { get; set; }
        public Nullable<int> cant { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        public virtual Devolucion Devolucion { get; set; }
        public virtual Producto Producto { get; set; }
    }
}