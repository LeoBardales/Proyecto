using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto
{
    public partial class RegistroIngreso : Form
    {
        public RegistroIngreso()
        {
            InitializeComponent();
            llenartabla();
        }

       
        conexion con = new conexion();
        public void llenartabla() {
            
                SqlDataAdapter datos = new SqlDataAdapter("select *from RegistroIngreso", con.conectar);
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenartabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Constancias c = new Constancias();
            c.Show();
        }
    }
}
