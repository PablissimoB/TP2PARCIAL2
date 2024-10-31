using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleFactura
    {
        public int idDetalleFactura { get; set; }
        Insumo? insumo { get; set; }//
        Factura factura { get; set; }//
        public string? detalle { get; set; }//
        public decimal cantidad { get; set; }//
        public double netoUnitario { get; set; }//
        public decimal alicuotaIva { get; set; }//
        Cuenta? cuenta { get; set; }//

        public DetalleFactura() { }
    }
}
