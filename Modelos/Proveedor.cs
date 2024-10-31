using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string cuit { get; set; }
        public string nombre { get; set; }
        public int iva { get; set; }

        public Proveedor() { }
    }
}
