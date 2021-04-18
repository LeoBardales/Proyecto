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


                SqlCommand comando = new SqlCommand("select *from SaldoProveedor(@ID) ", con.conectar);
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
                    cmbtipo.Text= Registro["TIPO DE PROVEEDOR"].ToString();
                    actualizar(true);

                }
                else
                {
                    MessageBox.Show("NO EXISTE NINGUN PROVEEDOR CON ESE ID");
                    actualizar(false);

                }
                con.close();
            }

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }


        string tipo = "";
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
                    tipo = Registro["TIPOPROVEEDORID"].ToString();
                    actualizar(true);

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
                    tipo = Registro["TIPOPROVEEDORID"].ToString();
                    actualizar(true);

                }
                else
                {
                    MessageBox.Show("NO HAY MAS REGISTRO DE PROVEEDORES");
                   
                }
                con.close();
            }
            if (tipo=="1") { cmbtipo.Text = "NACIONAL"; }
            if (tipo == "2") { cmbtipo.Text = "INTERNACIONAL"; }
            tipo = "";
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
                tipo = Registro["TIPOPROVEEDORID"].ToString();
                actualizar(true);

            }
            else
            {
                MessageBox.Show("NO HAY MAS REGISTRO DE PROVEEDORES");
                
            }
            con.close();
            if (tipo == "1") { cmbtipo.Text = "NACIONAL"; }
            if (tipo == "2") { cmbtipo.Text = "INTERNACIONAL"; }
            tipo = "";
        }

        private void LblSaldo_Click(object sender, EventArgs e)
        {

        }
        public void actualizar(Boolean res) {
            btnActualizar.Enabled = res;
            btnEliminar.Enabled = res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListaProveedores lp = new ListaProveedores();
            lp.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cmbtipo.Text == "NACIONAL") { tipo = "1"; }
            if (cmbtipo.Text == "INTERNACIONAL") { tipo = "2"; }
            try
            {
                SqlCommand command = new SqlCommand("execute spUpdateProveedores "+txtID.Text+ ",'"+ txtNOMBRE.Text + "'," + txtRTN.Text + ",'" + txtCONTACTO.Text + "','" + txtTELEFONO.Text + "'," + tipo + ",'" + txtEMAIL.Text + "'," + txtLIMITE.Text + "", con.conectar);
                con.abrir();
                command.ExecuteNonQuery();
                con.close();
                MessageBox.Show("Datos Actualizados");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Detecto un Error " + ex.Message);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
    
    
}

