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
    public partial class Cheque : Form
    {
        public Cheque()
        {
            InitializeComponent();
            llenarProv();
        }

        private void Cheque_Load(object sender, EventArgs e)
        {

        }
        conexion con = new conexion();
        public void llenarProv()
        {
            SqlCommand comando = new SqlCommand("select *from ProveedoresID", con.conectar);

            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                cmbProv.Items.Add(Registro["ProveedorID"].ToString());


            }

            con.close();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtBeneficiario.Text != "" && txtvalor.Text != "" && txtdesc.Text != "" && cmbProv.Text != "" && cmbbanco.Text != "" && cmbcuenta.Text != "")
            {

                String tipo = "";
                String estado = "";
               
                try
                {
                    SqlCommand comando = new SqlCommand("execute spInsertCheque "+cmbbanco.Text+","+cmbcuenta.Text+",'"+txtBeneficiario.Text + "','"+txtdesc.Text + "',"+txtvalor.Text+",P,P,"+cmbProv.Text+"", con.conectar);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("CHEQUE EXTENDIDO");
                    limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS"); };
        }
        public void limpiar() {
            txtBeneficiario.Text = "";
            txtdesc.Text = "";
            txtvalor.Text = "";

        }
    }
}
