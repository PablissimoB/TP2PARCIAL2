using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        Producto? producto { get; set; }//
        Venta venta { get; set; }//
        public string? detalle { get; set; }//
        public decimal cantidad { get; set; }//
        public double netoUnitario { get; set; }//
        public decimal alicuotaIva { get; set; }//
        Cuenta? cuenta { get; set; }//
    }
}
