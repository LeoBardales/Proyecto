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
    public partial class PagoFactura : Form
    {
        public PagoFactura()
        {
            InitializeComponent();
            CargandoClientes();
        }
        conexion con = new conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbcliente.Text!="" && textBox1.Text!="") {
                try
                {
                    
                    SqlCommand comando = new SqlCommand("execute spInsertRecibo " + cmbcliente.Text + "," + textBox1.Text + "", con.conectar);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("SE A PAGADO EL MONTO: " + textBox1.Text);
                    textBox1.Text = "";
                    cmbcliente.Text = "";

                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex); }

            }
        }
        public void CargandoClientes()
        {
            SqlCommand comando = new SqlCommand("select *from ClienteID", con.conectar);

            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                if (Registro["clienteid"].ToString()!="0") { cmbcliente.Items.Add(Registro["clienteid"].ToString()); }
                
            }

            con.close();
        }
    }
}
