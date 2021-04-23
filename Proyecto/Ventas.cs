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
    public partial class Ventas : Form
    {


        public Ventas()
        {
            InitializeComponent();
        }

        conexion con = new conexion();
      


        public void CargandoClientes()
        {
            SqlCommand comando = new SqlCommand("select *from ClienteID", con.conectar);

            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                cmbCLIENTE.Items.Add(Registro["clienteid"].ToString());
            }

            con.close();
        }

        public void Articulos()
        {
            SqlCommand comando = new SqlCommand("select *from Articulos", con.conectar);

            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                cmbARTICULO.Items.Add(Registro["ID"].ToString());
            }

            con.close();
        }

        public void MostrarDatos()
        {
            SqlDataAdapter datos = new SqlDataAdapter("select *from ListaFactura", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataAdapter dts = new SqlDataAdapter("select *from ListaFacturaDetalle", con.conectar);
            DataTable dt1 = new DataTable();
            dts.Fill(dt1);
            dataGridView2.DataSource = dt1;


        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargandoClientes();
            Articulos();
            Botones();
            cajasTextoP();
            MostrarDatos();

            SqlCommand comand = new SqlCommand("select *from MaxFacturaID", con.conectar);

            con.abrir();
            SqlDataReader Registro = comand.ExecuteReader();
            Registro.Read();

            txtFACTURA.Text = Registro["Maxima"].ToString();
            con.close();
        }

        public void Botones()
        {
            btnINGRESARPRODUCTOS.Enabled = false;
            btnACTUALIZARDETALLEVENTA.Enabled = false;
            btnACTUALIZARVENTA.Enabled = false;
            btnELIMINARDETALLEVENTA.Enabled = false;
            btnVENTAELIMINAR.Enabled = false;
        }

        public void cajasTextoP()
        {
            txtCANTIDAD.Enabled = false;
            txtDESCUENTO.Enabled = false;
            txtFACTURA.Enabled = true;
            cmbARTICULO.Enabled = true;
        }



        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void tabla()
        {


        }

        private void BtnVENTA_Click(object sender, EventArgs e)
        {
            if (cmbCLIENTE.Text != "" && cmbPAGO.Text != "" && cmbTIPOVENTA.Text != "")
            {
                
                String pago = "";
                int tipoVenta = 0;
                int clienteID = Int32.Parse(cmbCLIENTE.Text);
                if (cmbTIPOVENTA.Text == "AL POR MAYOR") { tipoVenta = 1; }
                if (cmbTIPOVENTA.Text == "AL DETALLE") { tipoVenta = 2; }
                if (cmbPAGO.Text == "CONTADO") { pago = "c"; }
                if (cmbPAGO.Text == "CREDITO") { pago = "r"; }
             

                    SqlCommand comando = new SqlCommand("execute spInsertFactura @ID, @TIPOV,'@PAGO'", con.conectar);
                    comando.Parameters.AddWithValue("@ID", clienteID);
                    comando.Parameters.AddWithValue("@TIPOV", tipoVenta);
                    comando.Parameters.AddWithValue("@PAGO", pago);
                  
                     MessageBox.Show("DATOS INGRESADOS");
                    
                    btnVENTA.Enabled = false;
                    btnINGRESARPRODUCTOS.Enabled = true;
                    txtCANTIDAD.Enabled = true;
                    txtDESCUENTO.Enabled = true;
                    txtFACTURA.Enabled = true;
                    cmbARTICULO.Enabled = true;
                
            }
            else { MessageBox.Show("INGRESE TODOS LOS DATOS"); }
            
            SqlCommand comand = new SqlCommand("select *from MaxFacturaID", con.conectar);

            con.abrir();
            SqlDataReader Registro = comand.ExecuteReader();
            Registro.Read();

            txtFACTURA.Text = Registro["Maxima"].ToString();

            con.close();


        }


        private void BtnINGRESARPRODUCTOS_Click(object sender, EventArgs e)
        {


            if (txtFACTURA.Text != "" && cmbARTICULO.Text != "" && txtDESCUENTO.Text != "" && txtCANTIDAD.Text != "" )
            {

                
                try
                {
                    SqlCommand comando = new SqlCommand("execute spInsertFacDetalle" + txtFACTURA.Text + "," + cmbARTICULO.Text + "," + txtCANTIDAD.Text + "," + txtDESCUENTO.Text + "", con.conectar);
                    MessageBox.Show("DATOS INGRESADOS");
                   }
                catch { MessageBox.Show("OCURRIO UN ERROR"); }
            }
            else { MessageBox.Show("INGRESE TODOS LOS DATOS"); }
            
        }

        private void BtnACTUALIZAR_Click(object sender, EventArgs e)
        {
            btnACTUALIZAR.Enabled = false;
            btnELIMINAR.Enabled = false;
            btnINGRESARPRODUCTOS.Enabled = false;
            btnELIMINARDETALLEVENTA.Enabled = false;
            btnVENTAELIMINAR.Enabled = false;
            btnACTUALIZARVENTA.Enabled = true;
            btnACTUALIZARDETALLEVENTA.Enabled = true;
        }

        private void BtnELIMINAR_Click(object sender, EventArgs e)
        {
            btnACTUALIZAR.Enabled = false;
            btnELIMINAR.Enabled = false;
            btnINGRESARPRODUCTOS.Enabled = false;
            btnVENTA.Enabled = false;
            btnELIMINARDETALLEVENTA.Enabled = true;
            btnVENTAELIMINAR.Enabled = true;
            


        }

        private void BtnVENTAELIMINAR_Click(object sender, EventArgs e)
        {
            SqlCommand comand = new SqlCommand("select *from MaxFacturaID", con.conectar);

            con.abrir();
            SqlDataReader Registro = comand.ExecuteReader();
            Registro.Read();
            string idMax = Registro["Maxima"].ToString();
            string id = txtFACTURA.ToString();
            if (id == idMax || id != idMax)
            {

                SqlCommand comando = new SqlCommand("execute spDeleteFactura @ID", con.conectar);
                comando.Parameters.AddWithValue("@ID", id);
                MessageBox.Show("ELINIDADO CORRECTAMENTE");
            }
            else { MessageBox.Show("OCURRIO UN ERROR"); }
            con.close();
        }

        private void BtnCANCELAR_Click(object sender, EventArgs e)
        {
            Botones();
            cajasTextoP();
            Limpiar();
            btnVENTA.Enabled = true;
            btnACTUALIZAR.Enabled = true;
            btnELIMINAR.Enabled = true;
        }

        public void Limpiar() {
            txtCANTIDAD.Text = "";
            txtDESCUENTO.Text = "";
            txtFACTURA.Text = "";
            cmbARTICULO.Text = "";
            cmbCLIENTE.Text = "";
            cmbPAGO.Text = "";
            cmbTIPOVENTA.Text = "";
                }

        private void BtnACTUALIZARVENTA_Click(object sender, EventArgs e)
        {
            
            if (cmbCLIENTE.Text != "" && cmbPAGO.Text != "" && cmbTIPOVENTA.Text != "" && txtFACTURA.Text != "")
            {

                String pago = "";
                int tipoVenta = 0;
                int clienteID = Int32.Parse(cmbCLIENTE.Text);
                if (cmbTIPOVENTA.Text == "AL POR MAYOR") { tipoVenta = 1; }
                if (cmbTIPOVENTA.Text == "AL DETALLE") { tipoVenta = 2; }
                if (cmbPAGO.Text == "CONTADO") { pago = "c"; }
                if (cmbPAGO.Text == "CREDITO") { pago = "r"; }


                SqlCommand comando = new SqlCommand("execute spUpdateFacturaDatos "+txtFACTURA+", "+clienteID+", "+tipoVenta+", '"+pago+"'", con.conectar);
                
                MessageBox.Show("DATOS ACTUALIZADOS");

                                
                btnVENTA.Enabled = false;
                btnINGRESARPRODUCTOS.Enabled = true;
                txtCANTIDAD.Enabled = true;
                txtDESCUENTO.Enabled = true;
                txtFACTURA.Enabled = true;
                cmbARTICULO.Enabled = true;

            }
            else { MessageBox.Show("INGRESE TODOS LOS DATOS"); }

        
        }

        private void BtnELIMINARDETALLEVENTA_Click(object sender, EventArgs e)
        {
            if (cmbARTICULO.Text != "" && txtFACTURA.Text != "")

            {
                try
                {

                    SqlCommand comando = new SqlCommand("execute spDeleteFacDetalle "+txtFACTURA+","+cmbARTICULO+"", con.conectar);

                    MessageBox.Show("ELINIDADO CORRECTAMENTE");
                }
                catch { MessageBox.Show("NO SE PUDO ELIMINAR"); }
            }
            else { MessageBox.Show("CAMPOS REQUERIDOS: 'FACTURA Y ARTICULO'"); }
            con.close();
        }

        private void BtnACTUALIZARDETALLEVENTA_Click(object sender, EventArgs e)
        {
            if (txtFACTURA.Text != "" && cmbARTICULO.Text != "" && txtDESCUENTO.Text != "" && txtCANTIDAD.Text != "")
            {


                try
                {
                    SqlCommand comando = new SqlCommand("execute spUpdateFacDetalle" + txtFACTURA.Text + "," + cmbARTICULO.Text + "," + txtCANTIDAD.Text + "," + txtDESCUENTO.Text + "", con.conectar);
                    MessageBox.Show("DATOS INGRESADOS");
                }
                catch { MessageBox.Show("OCURRIO UN ERROR"); }
            }
            else { MessageBox.Show("INGRESE TODOS LOS DATOS"); }
        }
    }
   
}


    

