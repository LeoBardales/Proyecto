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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }
        conexion con = new conexion();
        public void MostrarAllDatos()
        {
            SqlDataAdapter datos = new SqlDataAdapter("select *from Articulos", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void MostrarComprasDatos()
        {
            SqlDataAdapter datos = new SqlDataAdapter("select *from ExistenciasArticulos", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            MostrarAllDatos();
            cmbOpc.Text = "TODOS";
        }

        private void cmbOpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpc.Text=="TODOS") { MostrarAllDatos(); }
            if (cmbOpc.Text == "LISTOS PARA COMPRAS") { MostrarComprasDatos(); }
        }
    }
}
