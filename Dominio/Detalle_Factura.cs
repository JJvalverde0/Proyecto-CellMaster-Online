namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle_Facura
    {
        public int Id_DetalleFactura { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> id_factura { get; set; }
        public Nullable<int> Id_Producto { get; set; }
        public Nullable<int> IDTipoCambio { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual TipoCambio TipoCambio { get; set; }
        public virtual Producto Producto { get; set; }
    }
}