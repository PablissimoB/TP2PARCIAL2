using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Pago
    {
        public int idPago { get; set; }
        Proveedor proveedor { get; set; }//
        public DateTime fecha { get; set; }//
        public string? referencia { get; set; }//
        Factura? factura { get; set; }//
        Cuenta? cuenta { get; set; }//
        Moneda moneda { get; set; }//
        public decimal tipoCambio { get; set; }//
        public double? monto { get; set; }//
        public int tipoPago { get; set; } // 1 - pago | 2 - retencion IVA | 3 - retencion Ganancias
        public int? regimen { get; set; } // 1 - cosas muebles | 2 - servicios - 3 Arrendamientos
        public Pago() { }
    }
}
