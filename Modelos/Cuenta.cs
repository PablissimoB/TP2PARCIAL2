using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cuenta
    {
        public int idCuenta { get; set; }
        public string detalle { get; set; }
        public string codigo { get; set; }
        TipoCuenta tipoCuenta { get; set; }

    }
}
