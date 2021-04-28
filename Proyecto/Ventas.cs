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
            SqlDataAdapter datos = new SqlDataAdapter("select *from facturaactual("+ ventaID + ")", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataAdapter dts = new SqlDataAdapter("select *from facturdetalleaactual("+ventaID+")", con.conectar);
            DataTable dt1 = new DataTable();
            dts.Fill(dt1);
            dataGridView2.DataSource = dt1;


        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            
           
            con.close();

            if (cmbCLIENTE.Text == "") {
                CargandoClientes();
                Articulos();
            }
                
                if (cmbCLIENTE.Text == "0")
                {
                    
                    
                    cmbPAGO.Enabled = false;
                    cmbTIPOVENTA.Enabled = false;

                cmbPAGO.Text = "CONTADO";
                cmbTIPOVENTA.Text = "DETALLE";

                    
                }else {
                cmbPAGO.Enabled = true;
                cmbTIPOVENTA.Enabled = true;
                limpiarAll();
            }
            
        }

        public void Botones(Boolean b)
        {
            btnINGRESARPRODUCTOS.Enabled = b;
            btnlimpiar.Enabled = b;
            btnCANCELAR.Enabled = b;
            btnVENTA.Enabled = !b;
            cmbARTICULO.Enabled = b;
            txtCANTIDAD.Enabled = b;
            txtDESCUENTO.Enabled = b;

           
        }

        string cliente = "";
        int ventaID = 0;
        private void BtnVENTA_Click(object sender, EventArgs e)
        {
            if (cmbCLIENTE.Text != "" && cmbPAGO.Text != "" && cmbTIPOVENTA.Text != "")
            {
                cliente = cmbCLIENTE.Text;
                String pago = "";
                int tipoVenta = 0;
                int clienteID = Int32.Parse(cmbCLIENTE.Text);
                if (cmbTIPOVENTA.Text == "AL POR MAYOR") { tipoVenta = 1; }
                if (cmbTIPOVENTA.Text == "DETALLE") { tipoVenta = 2;  }
                if (cmbPAGO.Text == "CREDITO") { pago = "c"; btncobrar.Visible = false; }
                if (cmbPAGO.Text == "CONTADO") { pago = "r"; btncobrar.Visible = true; }
                try {
                    SqlCommand comando = new SqlCommand("execute spInsertFactura @ID, @TIPOV,@PAGO", con.conectar);
                    comando.Parameters.AddWithValue("@ID", clienteID);
                    comando.Parameters.AddWithValue("@TIPOV", tipoVenta);
                    comando.Parameters.AddWithValue("@PAGO", pago);
                    con.abrir();
                    SqlDataReader Registro = comando.ExecuteReader();
                    if (Registro.Read())
                    {
                        ventaID = Int32.Parse(Registro["ID"].ToString());
                        MessageBox.Show("DATOS INGRESADOS");
                    }
                    else
                    {
                        MessageBox.Show("NO HAY MAS REGISTRO DE PROVEEDORES");

                    }

                    con.close();
                    MostrarDatos();
                    Botones(true);



                } catch (Exception ex) {
                    MessageBox.Show("error: "+ex);
                }
                    
                
            }
            else { MessageBox.Show("INGRESE TODOS LOS DATOS"); }
        }


        private void BtnINGRESARPRODUCTOS_Click(object sender, EventArgs e)
        {


            if (cmbARTICULO.Text != "" && txtDESCUENTO.Text != "" && txtCANTIDAD.Text != "" )
            {

                
                try
                {
                    SqlCommand comando = new SqlCommand("execute spInsertFacDetalle @ID,@ARTICULO,@CANTIDAD,@DECSCUENTO", con.conectar);
                    comando.Parameters.AddWithValue("@ID", ventaID);
                    comando.Parameters.AddWithValue("@ARTICULO", cmbARTICULO.Text);
                    comando.Parameters.AddWithValue("@CANTIDAD", txtCANTIDAD.Text);
                    comando.Parameters.AddWithValue("@DECSCUENTO", txtDESCUENTO.Text);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    MostrarDatos();
                    con.close();
                    txtCANTIDAD.Text = "";
                    lblexist.Text = "";
                    txtDESCUENTO.Text = "";
                    cmbARTICULO.Text = "";
                    btnELIMINAR.Enabled = true;
                   }
                catch(Exception ex) { MessageBox.Show("OCURRIO UN ERROR: "+ex); }
            }
            else { MessageBox.Show("INGRESE TODOS LOS DATOS"); }
            
        }

      
        public void Limpiar() {
            txtCANTIDAD.Text = "";
            txtDESCUENTO.Text = "";
            cmbARTICULO.Text = "";
            cmbCLIENTE.Text = "";
            cmbPAGO.Text = "";
            cmbTIPOVENTA.Text = "";
                }

              

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            if (cmbCLIENTE.Text != "")

            {
                try
                {

                    SqlCommand comando = new SqlCommand("execute spDeleteFactura " + ventaID + "", con.conectar);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("ELINIDADO CORRECTAMENTE");
                    Botones(false);
                    limpiarAll();
                }
                catch { MessageBox.Show("NO SE PUDO ELIMINAR"); }
            }
            else { MessageBox.Show("CAMPOS REQUERIDOS: 'CLIENTE'"); }

        }
        public void limpiarAll() {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();
            txtCANTIDAD.Text = "";
            txtDESCUENTO.Text = "";
            cmbTIPOVENTA.Text = "";
            cmbPAGO.Text = "";
            btncobrar.Visible = false;

        }
        public void cantidad(String art, int cant) {
            int existencias=0;
            txtCANTIDAD.DataSource = null;
            txtCANTIDAD.Items.Clear();
            try
            {
                SqlCommand comando = new SqlCommand("select dbo.CantArticulo (" + art + ")", con.conectar);
                con.abrir();
                existencias = Int32.Parse(comando.ExecuteScalar().ToString());
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            existencias += cant;
            lblexist.Text ="EN EXISTENCIAS: "+existencias.ToString();
            for (int x=1;x<=existencias;x++) {
                txtCANTIDAD.Items.Add(x);
            }

        }

        private void cmbARTICULO_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidad(cmbARTICULO.Text,0);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = Int32.Parse(dataGridView2.CurrentRow.Index.ToString());
                int cant = 0;
                String art = "";

                art = dataGridView2.Rows[fila].Cells[1].Value.ToString();
                cant = Int32.Parse(dataGridView2.Rows[fila].Cells[3].Value.ToString());
                txtDESCUENTO.Text = dataGridView2.Rows[fila].Cells[4].Value.ToString();
                
                btnELIMINAR.Enabled = true;
                cmbARTICULO.Text = art;
                txtCANTIDAD.Text = cant.ToString();
                cantidad(art,cant);
                
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex); }
        }

        

        

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = Int32.Parse(dataGridView2.CurrentRow.Index.ToString());
                int cant = 0;
                String art = "";
                string desc = "";

                art = dataGridView2.Rows[fila].Cells[1].Value.ToString();
                cant = Int32.Parse(dataGridView2.Rows[fila].Cells[3].Value.ToString());
                desc = dataGridView2.Rows[fila].Cells[4].Value.ToString();
                MessageBox.Show(desc.ToString());


                
                    SqlCommand comando1 = new SqlCommand("execute spUpdateFacturaDetalle " + ventaID + "," + art + "," + cant + "," + desc + "", con.conectar);
                    con.abrir();
                    comando1.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                    MostrarDatos();
                    cmbARTICULO.Text = "";
                    txtCANTIDAD.Text = "";
                    txtDESCUENTO.Text = "";
                
               
               


            }
            catch { MessageBox.Show("NO SE PUDO actualizar"); }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int fila = Int32.Parse(dataGridView1.CurrentRow.Index.ToString());
               
                String tipov = "";
                String tipo = "";
                String cliente = cmbCLIENTE.Text;
                int tv = 0;
                String t = "";
                int venta = 0;

                cmbPAGO.Text = "";
                cmbTIPOVENTA.Text = "";

                venta = Int32.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                
                tipov = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                tipo = dataGridView1.Rows[fila].Cells[3].Value.ToString();


                
                if (tipov == "AL POR MAYOR"){
                    tv = 1;
                    
                   
                }

                if (tipov == "DETALLE")
                {
                    tv = 2;
                }

                if (tipo == "CREDITO")
                {
                    t = "c";
                    btncobrar.Visible = false;
                }

                if (tipo == "CONTADO")
                {
                    t = "r";
                    btncobrar.Visible = true;
                }

                
                SqlCommand comando1 = new SqlCommand("execute spUpdateFacturaDatos " + venta + ",'" + cliente + "'," + tv + ",'" + t + "'", con.conectar);
                con.abrir();
                comando1.ExecuteNonQuery();
                con.close();
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                MostrarDatos();
                cmbCLIENTE.Text = "";
                cmbPAGO.Text = "";
                cmbTIPOVENTA.Text = "";





            }
            catch { MessageBox.Show("NO SE PUDO actualizar"); }
        }

        private void BtnELIMINAR_Click(object sender, EventArgs e)
        {
            if (cmbARTICULO.Text != "")            
            {
                String articulo = cmbARTICULO.Text;
                try
                {

                    SqlCommand comando = new SqlCommand("execute spDeleteFacDetalle " + ventaID + "," + articulo +"", con.conectar);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("ELINIDADO CORRECTAMENTE");
                    MostrarDatos();
                    cmbARTICULO.Text = "";
                    txtCANTIDAD.Text = "";
                    txtDESCUENTO.Text = "";
                    
                }
                catch { MessageBox.Show("NO SE PUDO ELIMINAR"); }
            }
            else { MessageBox.Show("CAMPOS REQUERIDOS: 'ARTICULO'"); }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Botones(false);
            limpiarAll();
            btnELIMINAR.Enabled = false;
            
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            try {
                String precio = dataGridView1.Rows[0].Cells[6].Value.ToString();
                SqlCommand comando = new SqlCommand("execute spInsertRecibo " + cliente + "," + precio + "", con.conectar);
                con.abrir();
                comando.ExecuteNonQuery();
                con.close();
                MessageBox.Show("SE A PAGADO EL MONTO: "+precio);
                MostrarDatos();
                btncobrar.Visible = false;
                btnCANCELAR.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
    }
  
   
}


    

