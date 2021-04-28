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
    public partial class MenuBodega : Form
    {
        public MenuBodega()
        {
            InitializeComponent();
        }

        private void btnClienteMes_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
                ingreso.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroIngreso ri = new RegistroIngreso();
            ri.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ElaboracionProductos ep = new ElaboracionProductos();
            ep.Show();
        }
    }
}
