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
    public partial class Constancias : Form
    {
        conexion con = new conexion();
        public Constancias()
        {
            InitializeComponent();
            llenartabla();
        }
        public void llenartabla()
        {

            SqlDataAdapter datos = new SqlDataAdapter("select *from constancias", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenartabla();
        }
    }
}
