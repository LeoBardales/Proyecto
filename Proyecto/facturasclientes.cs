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
    public partial class facturasclientes : Form
    {
        public facturasclientes()
        {
            InitializeComponent();
            CargandoClientes();
        }
       
        conexion con = new conexion();
    private void facturasclientes_Load(object sender, EventArgs e)
        {

        }
        public void CargandoClientes()
        {
            SqlCommand comando = new SqlCommand("select *from ClienteID", con.conectar);

            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                if (Registro["clienteid"].ToString() != "0") { cmbcliente.Items.Add(Registro["clienteid"].ToString()); }

            }

            con.close();
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDatos(cmbcliente.Text);
        }
        public void MostrarDatos(String cliente)
        {

            SqlDataAdapter datos = new SqlDataAdapter("select *from dbo.facturascliente("+cliente+")", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;
            try
            {
                SqlCommand comando = new SqlCommand("select dbo.versaldocliente (" + cliente + ")", con.conectar);
                con.abrir();
                lbltexto.Text = "EL SALDO DEL CLIENTE SELECCIONADO ES: " + comando.ExecuteScalar().ToString() + " LPS";
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbcliente.Text != "" && textBox1.Text != "")
            {
                try
                {

                    SqlCommand comando = new SqlCommand("execute spInsertRecibo " + cmbcliente.Text + "," + textBox1.Text + "", con.conectar);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("SE A PAGADO EL MONTO: " + textBox1.Text);
                    MostrarDatos(cmbcliente.Text);
                    textBox1.Text = "";
                    cmbcliente.Text = "";

                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex); }
               

            }
        }
    }
}
