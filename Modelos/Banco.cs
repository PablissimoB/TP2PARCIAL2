using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Banco
    {
        public int idBanco { get; set; }
        public string nombreBanco { get; set; }
        Moneda moneda { get; set; }
        public int tipoCuenta { get; set; } // 1 Cta Cte - 2 Caja Ahorro - 3 
        public string? detalle { get; set; }
        public string? cbu { get; set; }
        public Banco() { }
    }
}
