using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class VentasMenu : Form
    {
        public VentasMenu()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ClienteN frm = new ClienteN();
            frm.Show();
        }

        

        private void VENTAS_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
        }

        private void btnpago_Click(object sender, EventArgs e)
        {
            PagoFactura pf = new PagoFactura();
            pf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            facturasclientes fc = new facturasclientes();
            fc.Show();
        }
    }
}
