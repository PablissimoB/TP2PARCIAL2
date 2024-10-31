using Presentacion;
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
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_SizeChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProveedor formProveedor = new FormProveedor();
            formProveedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDetalleFactura formDetalleFactura = new FormDetalleFactura();
            formDetalleFactura.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCuenta formCuenta = new FormCuenta();
            formCuenta.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCentro formCentroCosto = new FormCentro();
            formCentroCosto.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormPago formPago = new FormPago();
            formPago.Show();
        }
    }
}
