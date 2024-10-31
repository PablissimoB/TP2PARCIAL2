using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agron
{
    public partial class FormDetalleFactura : Form
    {
        public FormDetalleFactura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCuenta formCuenta = new FormCuenta();
            formCuenta.Show();
        }

        private void FormDetalleFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
