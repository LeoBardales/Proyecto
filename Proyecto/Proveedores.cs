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

    public partial class Proveedores : Form
    {
        conexion con = new conexion();

        public Proveedores()
        {
            InitializeComponent();



        }
        string dato;

        private void MostrarDatos_Click(object sender, EventArgs e)
        {
            dato = txtID.Text;
            if (dato == "")
            {
                MessageBox.Show("NO EXISTE NINGUN PROVEEDOR CON ESE ID");
            }
            else
            {
                int id = Convert.ToInt32(dato);


                SqlCommand comando = new SqlCommand("execute spSelectProveedores @ID", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                con.abrir();
                SqlDataReader Registro = comando.ExecuteReader();
                if (Registro.Read())
                {
                    txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                    txtRTN.Text = Registro["RTN"].ToString();
                    txtCONTACTO.Text = Registro["CONTACTO"].ToString();
                    txtTELEFONO.Text = Registro["TELEFONO"].ToString();
                    txtEMAIL.Text = Registro["EMAIL"].ToString();
                    txtLIMITE.Text = Registro["LIMITE"].ToString();
                    txtSALDO.Text = Registro["SALDO"].ToString();

                }
                else
                {
                    MessageBox.Show("NO EXISTE NINGUN PROVEEDOR CON ESE ID");

                }
                con.close();
            }

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }


     
        private void Siguiente_Click(object sender, EventArgs e)
        {
            dato = txtID.Text;
            if (dato == "")
            {

                int id = 0;

                ++(id);
                SqlCommand comando = new SqlCommand("execute spSelectProveedores @ID", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                con.abrir();
                SqlDataReader Registro = comando.ExecuteReader();
                if (Registro.Read())
                {
                    txtID.Text = Registro["PROVEEDORID"].ToString();
                    txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                    txtRTN.Text = Registro["RTN"].ToString();
                    txtCONTACTO.Text = Registro["CONTACTO"].ToString();
                    txtTELEFONO.Text = Registro["TELEFONO"].ToString();
                    txtEMAIL.Text = Registro["EMAIL"].ToString();
                    txtLIMITE.Text = Registro["LIMITE"].ToString();
                    txtSALDO.Text = Registro["SALDO"].ToString();

                }
                else
                {
                    MessageBox.Show("NO HAY MAS REGISTRO DE PROVEEDORES");
                }
                con.close();
            }
            else
            {
                int id = Convert.ToInt32(dato);
                ++(id);
                SqlCommand comando = new SqlCommand("execute spSelectProveedores @ID", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                con.abrir();
                SqlDataReader Registro = comando.ExecuteReader();
                if (Registro.Read())
                {
                    txtID.Text = Registro["PROVEEDORID"].ToString();
                    txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                    txtRTN.Text = Registro["RTN"].ToString();
                    txtCONTACTO.Text = Registro["CONTACTO"].ToString();
                    txtTELEFONO.Text = Registro["TELEFONO"].ToString();
                    txtEMAIL.Text = Registro["EMAIL"].ToString();
                    txtLIMITE.Text = Registro["LIMITE"].ToString();
                    txtSALDO.Text = Registro["SALDO"].ToString();

                }
                else
                {
                    MessageBox.Show("NO HAY MAS REGISTRO DE PROVEEDORES");
                }
                con.close();
            }
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            dato = txtID.Text;
            int id = Convert.ToInt32(dato);
            --(id);
            SqlCommand comando = new SqlCommand("execute spSelectProveedores @ID", con.conectar);
            comando.Parameters.AddWithValue("@ID", id);
            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            if (Registro.Read())
            {
                txtID.Text = Registro["PROVEEDORID"].ToString();
                txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                txtRTN.Text = Registro["RTN"].ToString();
                txtCONTACTO.Text = Registro["CONTACTO"].ToString();
                txtTELEFONO.Text = Registro["TELEFONO"].ToString();
                txtEMAIL.Text = Registro["EMAIL"].ToString();
                txtLIMITE.Text = Registro["LIMITE"].ToString();
                txtSALDO.Text = Registro["SALDO"].ToString();

            }
            else
            {
                MessageBox.Show("NO HAY MAS REGISTRO DE PROVEEDORES");
            }
            con.close();
        }

        private void LblSaldo_Click(object sender, EventArgs e)
        {

        }
    }
    
}

