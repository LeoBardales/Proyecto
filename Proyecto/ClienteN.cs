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
    public partial class ClienteN : Form
    {
        conexion con = new conexion();
        public ClienteN()
        {
            InitializeComponent();
        }
        
        string dato;
        private void btnMOSTRARDATOS_Click(object sender, EventArgs e)
        {
            dato = txtID.Text;
            if (dato == "")
            {
                MessageBox.Show("NO EXISTE NINGUN CLIENTE CON ESE ID");
            }
            else
            {
                int id = Convert.ToInt32(dato);


                SqlCommand comando = new SqlCommand("execute spSelectCliente @id", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                con.abrir();
                SqlDataReader Registro = comando.ExecuteReader();
                if (Registro.Read())
                {
                    txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                    txtDIRECCION.Text = Registro["DIRECCION"].ToString();
                    txtESTADOCIVIL.Text = Registro["ESTADOCIVIL"].ToString();
                    txtLIMITE.Text = Registro["LIMITE"].ToString();
                   
                    txtSALDO.Text = Registro["SALDO"].ToString();
                    txtSALDO.Text = Registro["SALDO"].ToString();

                    string TIPO = Registro["TIPO"].ToString();
                    if (TIPO == "N") { cmbTIPO.Text = "NATURAL"; }
                    else { cmbTIPO.Text = "JURIDICO"; }

                    string SEXO = Registro["SEXO"].ToString();
                    if (SEXO == "M") { cmbSEXO.Text = "MASCULINO"; }
                    else { cmbSEXO.Text = "FEMENINO"; }
                    ACTUALIZAR(true);

                }
                else
                {
                    MessageBox.Show("NO EXISTE NINGUN CLIENTE CON ESE ID");
                    ACTUALIZAR(false);

                }
                con.close();
            }
        }

        private void btnSIGUIENTE_Click(object sender, EventArgs e)
        {
            dato = txtID.Text;
            if (dato == "")
            {

                int id = 0;

                ++(id);
                SqlCommand comando = new SqlCommand("execute spSelectCliente @id", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                con.abrir();
                SqlDataReader Registro = comando.ExecuteReader();
                if (Registro.Read())
                {
                    txtID.Text = Registro["CLIENTEID"].ToString();
                    txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                    txtDIRECCION.Text = Registro["DIRECCION"].ToString();
                    txtESTADOCIVIL.Text = Registro["ESTADOCIVIL"].ToString();
                    txtLIMITE.Text = Registro["LIMITE"].ToString();

                    txtSALDO.Text = Registro["SALDO"].ToString();
                    txtSALDO.Text = Registro["SALDO"].ToString();

                    string TIPO = Registro["TIPO"].ToString();
                    if (TIPO == "N") { cmbTIPO.Text = "NATURAL"; }
                    else { cmbTIPO.Text = "JURIDICO"; }

                    string SEXO = Registro["SEXO"].ToString();
                    if (SEXO == "M") { cmbSEXO.Text = "MASCULINO"; }
                    else { cmbSEXO.Text = "FEMENINO"; }
                    ACTUALIZAR(true);

                }
                else
                {
                    MessageBox.Show("NO HAY MAS CLIENTES");


                }
                con.close();
            }
            else
            {
                int id = Convert.ToInt32(dato);
                ++(id);
                
                SqlCommand comando = new SqlCommand("execute spSelectCliente @id", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                con.abrir();
                SqlDataReader Registro = comando.ExecuteReader();
                if (Registro.Read())
                {
                    txtID.Text = Registro["CLIENTEID"].ToString();
                    txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                    txtDIRECCION.Text = Registro["DIRECCION"].ToString();
                    txtESTADOCIVIL.Text = Registro["ESTADOCIVIL"].ToString();
                    txtLIMITE.Text = Registro["LIMITE"].ToString();

                    txtSALDO.Text = Registro["SALDO"].ToString();
                    txtSALDO.Text = Registro["SALDO"].ToString();

                    string TIPO = Registro["TIPO"].ToString();
                    if (TIPO == "N") { cmbTIPO.Text = "NATURAL"; }
                    else { cmbTIPO.Text = "JURIDICO"; }

                    string SEXO = Registro["SEXO"].ToString();
                    if (SEXO == "M") { cmbSEXO.Text = "MASCULINO"; }
                    else { cmbSEXO.Text = "FEMENINO"; }
                    ACTUALIZAR(true);

                }
                else
                {
                    MessageBox.Show("NO HAY MAS CLIENTE");


                }
                con.close();

            }
            }

        private void btnANTERIOR_Click(object sender, EventArgs e)
        {
            dato = txtID.Text;
            if (dato == "")
            {

                int id = 0;

                --(id);
                SqlCommand comando = new SqlCommand("execute spSelectCliente @id", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                con.abrir();
                SqlDataReader Registro = comando.ExecuteReader();
                if (Registro.Read())
                {
                    txtID.Text = Registro["CLIENTEID"].ToString();
                    txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                    txtDIRECCION.Text = Registro["DIRECCION"].ToString();
                    txtESTADOCIVIL.Text = Registro["ESTADOCIVIL"].ToString();
                    txtLIMITE.Text = Registro["LIMITE"].ToString();

                    txtSALDO.Text = Registro["SALDO"].ToString();
                    txtSALDO.Text = Registro["SALDO"].ToString();

                    string TIPO = Registro["TIPO"].ToString();
                    if (TIPO == "N") { cmbTIPO.Text = "NATURAL"; }
                    else { cmbTIPO.Text = "JURIDICO"; }

                    string SEXO = Registro["SEXO"].ToString();
                    if (SEXO == "M") { cmbSEXO.Text = "MASCULINO"; }
                    else { cmbSEXO.Text = "FEMENINO"; }
                    ACTUALIZAR(true);

                }
                else
                {
                    MessageBox.Show("NO HAY MAS CLIENTE");


                }
                con.close();
            }
            else
            {
                int id = Convert.ToInt32(dato);
                --(id);

                SqlCommand comando = new SqlCommand("execute spSelectCliente @id", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                con.abrir();
                SqlDataReader Registro = comando.ExecuteReader();
                if (Registro.Read())
                {
                    txtID.Text = Registro["CLIENTEID"].ToString();
                    txtNOMBRE.Text = Registro["NOMBRE"].ToString();
                    txtDIRECCION.Text = Registro["DIRECCION"].ToString();
                    txtESTADOCIVIL.Text = Registro["ESTADOCIVIL"].ToString();
                    txtLIMITE.Text = Registro["LIMITE"].ToString();

                    txtSALDO.Text = Registro["SALDO"].ToString();
                    txtSALDO.Text = Registro["SALDO"].ToString();

                    string TIPO = Registro["TIPO"].ToString();
                    if (TIPO == "N") { cmbTIPO.Text = "NATURAL"; }
                    else { cmbTIPO.Text = "JURIDICO"; }

                    string SEXO = Registro["SEXO"].ToString();
                    if (SEXO == "M") { cmbSEXO.Text = "MASCULINO"; }
                    else { cmbSEXO.Text = "FEMENINO"; }
                    ACTUALIZAR(true);

                }
                else
                {
                    MessageBox.Show("NO HAY MAS CLIENTE");
                    

                }
                con.close();

            }



        }

        private void ACTUALIZAR(Boolean res)
        {
            btnACTUALIZAR.Enabled = res;
            btnELIMINAR.Enabled = res;
        }

        public void NUEVO(Boolean b)
        {
            txtID.Enabled = b;
            btnMOSTRARDATOS.Enabled = b;
            btnSIGUIENTE.Enabled = b;
            btnANTERIOR.Enabled = b;
            //btnLISTA.Enabled = b;
            //btnSM.Enabled = b;
            btnNUEVO.Enabled = b;

            
            txtID.Text = "";
            txtLIMITE.Text = "";
            txtNOMBRE.Text = "";
            txtDIRECCION.Text = "";
            txtSALDO.Text = "";
            txtESTADOCIVIL.Text = "";
            cmbSEXO.Text = "";
            cmbTIPO.Text = "";

        }
        String TIPO = "";
        String SEXO = "";
        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            
            if (cmbTIPO.Text == "NATURAL") { TIPO = "N"; }
            if (cmbTIPO.Text == "JURIDICO") { TIPO = "J"; }
            if (cmbSEXO.Text == "MASCULINO") { SEXO = "M"; }
            if (cmbSEXO.Text == "FEMENINO") { SEXO = "F"; }
            try
            {
                SqlCommand command = new SqlCommand("execute spUpdateCliente " + txtID.Text + ",'" + txtNOMBRE.Text + "','" + txtDIRECCION.Text + "','" + TIPO + "','" + txtESTADOCIVIL.Text + "','" + SEXO + "'", con.conectar);
                con.abrir();
                command.ExecuteNonQuery();
                con.close();
                MessageBox.Show("Se Actualizaron los datos del Cliente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Detecto un Error " + ex.Message);
            }

        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand command = new SqlCommand("execute spDeleteCliente " + txtID.Text + "", con.conectar);
                con.abrir();
                command.ExecuteNonQuery();
                con.close();
                MessageBox.Show("Se ha eliminado el ciente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Detecto un Error " + ex.Message);
            }
            NUEVO(true);
            ACTUALIZAR(false);

        }

        private void BtnNUEVO_Click(object sender, EventArgs e)
        {
            NUEVO(false);
            ACTUALIZAR(false);
            btnGUARDAR.Enabled = true;
            btnCANCELAR.Enabled = true;


        }
        
        
        private void BtnGUARDAR_Click(object sender, EventArgs e)
        {
            if (txtNOMBRE.Text != "" && txtDIRECCION.Text != "" && txtESTADOCIVIL.Text != "" && txtLIMITE.Text != "" && cmbSEXO.Text != "" && cmbTIPO.Text != "")
            {
                
                if (cmbTIPO.Text == "NATURAL") { TIPO = "N"; }
                if (cmbTIPO.Text == "JURIDICO") { TIPO = "J"; }
                if (cmbSEXO.Text == "MASCULINO") { SEXO = "M"; }
                if (cmbSEXO.Text == "FEMENINO") { SEXO = "F"; }
                try
                {
                    SqlCommand command = new SqlCommand("execute spInsertCliente '" + txtNOMBRE.Text + "','" + TIPO + "','" + txtDIRECCION.Text + "','" + txtESTADOCIVIL.Text + "','" + SEXO + "'", con.conectar);
                    con.abrir();
                    command.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("Datos Guardados");
                    NUEVO(true);
                    btnGUARDAR.Enabled = false;
                    btnCANCELAR.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se Detecto un Error " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private void BtnCANCELAR_Click(object sender, EventArgs e)
        {
            NUEVO(true);
            btnGUARDAR.Enabled = false;
            btnCANCELAR.Enabled = false;
        }

        private void BtnSM_Click(object sender, EventArgs e)
        {
            ClienteMES c = new ClienteMES();
            c.Show();
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            ListaCLIENTE lc = new ListaCLIENTE();
            lc.Show();
        }
    }
    }

