using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class TipoCuenta
    {
        public int idTipoCuenta { get; set; }
        public string descripcion { get; set; }
        public int rubroPatrimonial { get; set; }//1 activo, 2 pasivo, 3 patrimonio neto, 4 positivo, 5 negativo
        public TipoCuenta() { }
    }
}
