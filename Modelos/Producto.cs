using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string detalle { get; set; }
        public string? otros { get; set; }
        Cuenta? cuenta { get; set; }
        public Producto() { }
    }
}
