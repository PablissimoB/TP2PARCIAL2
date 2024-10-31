using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cobro
    {
        public int idCobro { get; set; }
        Cliente cliente { get; set; }//
        public DateTime fecha { get; set; }//
        public string? referencia { get; set; }//
        Venta? venta { get; set; }//
        Cuenta? cuenta { get; set; }//
        Moneda moneda { get; set; }//
        public decimal tipoCambio { get; set; }//
        public double? monto { get; set; }//
        public int tipoCobro { get; set; } // 1 - pago | 2 - retencion IVA | 3 - retencion Ganancias | 4 - retencion SUSS | 5 - retencion IIBB
        
        public Cobro() { }
    }
}
