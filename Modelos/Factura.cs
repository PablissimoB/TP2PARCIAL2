using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Factura
    {
        public int idFactura { get; set; }//
        Proveedor proveedor { get; set; }//
        TipoComprobante tipoComprobante { get; set; }//
        Moneda moneda { get; set; }//
        public DateTime fecha { get; set; }//
        public int imputacion { get; set; }//
        public decimal tipoCambio { get; set; }//
        public int punto { get; set; }//
        public string numero { get; set; }//
        public double? netoGravado { get; set; }//
        public double? netoNoGravado { get; set; }//
        public double? exento { get; set; }//
        public double? iva { get; set; }//
        public double? percIVA { get; set; }//
        public double? percIIBB { get; set; }//
        public double? percMunicipalidad { get; set; }//
        CentroCosto? centroCosto { get; set; }

        public Factura() { }

    }
}
