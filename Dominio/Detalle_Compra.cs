namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle_Compra
    {
        public int Id_DetalleCompra { get; set; }
        public Nullable<decimal> Precio_Compra { get; set; }
        public Nullable<int> Cantidad_Producto { get; set; }
        public Nullable<decimal> TotalCompra { get; set; }
        public Nullable<int> Id_Compras { get; set; }
        public Nullable<int> Id_Producto { get; set; }
    
        public virtual Compras Compras { get; set; }
        public virtual Producto Producto { get; set; }
    }
}