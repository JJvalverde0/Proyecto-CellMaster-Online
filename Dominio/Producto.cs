namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Detalle_Compra = new HashSet<Detalle_Compra>();
            this.Detalle_Facura = new HashSet<Detalle_Facura>();
            this.DetalleDevolucion = new HashSet<DetalleDevolucion>();
        }
    
        public int Id_Producto { get; set; }
        public int CodigoProd { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<decimal> Precio_Venta { get; set; }
        public int Stock { get; set; }
        public Nullable<int> StockMinimo { get; set; }
        public int Id_Categorias { get; set; }
        public int Id_Marca { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Facura> Detalle_Facura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleDevolucion> DetalleDevolucion { get; set; }
        public virtual Marca Marca { get; set; }
    }
}