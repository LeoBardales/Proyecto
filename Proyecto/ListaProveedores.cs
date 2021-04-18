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
    public partial class ListaProveedores : Form
    {
        conexion con = new conexion();
        public ListaProveedores()
        {
            InitializeComponent();
        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
        public void MostrarDatos()
        {
            SqlDataAdapter datos = new SqlDataAdapter("select *from ListaProveedores", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
