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

        private void button1_Click(object sender, EventArgs e)
        {
            SaldoCdia frm = new SaldoCdia();
            frm.Show();
        }
    }
}
