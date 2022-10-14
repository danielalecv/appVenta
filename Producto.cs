using System;
using System.Collections.Generic;

namespace AppVenta.Dominio
{
    public class Producto
    {
        public Guid ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal CantidadEnStock { get; set; }
        public List<VentaDetalle> VentaDetalles { get; set; }
    }
}
