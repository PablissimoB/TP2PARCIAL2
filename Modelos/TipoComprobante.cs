using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class TipoComprobante
    {
        public int idTipo { get; set; }
        public string descripcion { get; set; }
        public string codigoAFIP { get; set; }
        public TipoComprobante() { }
    }
}
