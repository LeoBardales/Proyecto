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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
           
        }
        conexion con = new conexion();
        int compraID=0;
        private void Compras_Load(object sender, EventArgs e)
        {
            llenarProv();
        }
        public void llenarProv() {
            SqlCommand comando = new SqlCommand("select *from ProveedoresID", con.conectar);
            
            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                cmbProv.Items.Add( Registro["ProveedorID"].ToString());
                

            }
            
            con.close();
            
        }

        public void llenarArt()
        {
            cmbArticulos.DataSource = null;
            cmbArticulos.Items.Clear();
            SqlCommand comando = new SqlCommand("select *from ExistenciasArticulos", con.conectar);

            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                cmbArticulos.Items.Add(Registro["ID"].ToString());
            }

            con.close();

        }

        

        private void txtDocumento_KeyPres(object sender,
         KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text != "" && cmbTipo.Text != "" && cmbEstado.Text != "" && cmbProv.Text != "") {

                String tipo = "";
                String estado = "";
                if (cmbTipo.Text == "CREDITO") { tipo = "C"; }
                if (cmbTipo.Text == "CONTADO") { tipo = "R"; }
                if (cmbEstado.Text == "FACTURADO") { estado = "F"; }
                if (cmbEstado.Text == "PAGADO") { estado = "P"; }
                try
                {
                    SqlCommand comando = new SqlCommand("execute spInsertCompra "+ cmbProv.Text + ","+ txtDocumento.Text + ",'"+tipo+"','"+estado+"'", con.conectar);

                    con.abrir();
                    SqlDataReader Registro = comando.ExecuteReader();
                    if (Registro.Read())
                    {
                        compraID = Int32.Parse(Registro["ID"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("NO HAY MAS REGISTRO DE PROVEEDORES");

                    }
                    con.close();
                    llenarArt(); desbloquear(true);
                    TxtCompra.Text = compraID.ToString();
                    Total();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: "+ex);
                } 
            }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS");};
            
        }
        public void MostrarComprasDatos()
        {
            SqlDataAdapter datos = new SqlDataAdapter("select *from CompraActual("+compraID+")", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void desbloquear(Boolean opc) {
            btnCancelar.Enabled = opc;
            cmbArticulos.Enabled = opc;
            txtTotal.Visible = opc;
            TxtCompra.Visible = opc;
            lblCompra.Visible = opc;
            lblTotal.Visible = opc;
            btnCrear.Enabled = !opc;
            btnAgregar.Enabled = opc;
            TxtPrecio.Enabled = opc;
            txtCantidad.Enabled = opc;
            txtDescuento.Enabled = opc;
            btnactcompra.Enabled = opc;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.Text != "" && TxtPrecio.Text != "" && txtCantidad.Text!="" && txtDescuento.Text!="") {

                try
                {
                    SqlCommand comando = new SqlCommand("execute spInsertCompraDetalle " + compraID + "," + cmbArticulos.Text + "," + txtCantidad.Text + "," + TxtPrecio.Text + "," + txtDescuento.Text + "", con.conectar);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MostrarComprasDatos();
                    Total();
                    cmbArticulos.Text = "";
                    TxtPrecio.Text = "";
                    txtCantidad.Text = "";
                    txtDescuento.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }


                }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS"); };
        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.Text != "" && TxtPrecio.Text != "" && txtCantidad.Text != "" && txtDescuento.Text != "") {
                string articulo, cantidad, precio, descuento;
                articulo = cmbArticulos.Text;
                cantidad = txtCantidad.Text;
                precio = TxtPrecio.Text;
                descuento = txtDescuento.Text;
                try
                {
                    SqlCommand comando = new SqlCommand("execute spUpdateCompraDetalle @ID,@art,@cant,@precio,@desc", con.conectar);
                    comando.Parameters.AddWithValue("@ID", compraID.ToString());
                    comando.Parameters.AddWithValue("@art", articulo);
                    comando.Parameters.AddWithValue("@cant", cantidad);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@desc", descuento);

                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("Articulo Actualizar");
                    MostrarComprasDatos();
                    Total();
                    cmbArticulos.Text = "";
                    TxtPrecio.Text = "";
                    txtCantidad.Text = "";
                    txtDescuento.Text = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }


                 }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS"); };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    SqlCommand comando = new SqlCommand("execute spDeleteCompra " + compraID + "", con.conectar);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("Listo");
                    cmbArticulos.Text = "";
                    TxtPrecio.Text = "";
                    txtCantidad.Text = "";
                    txtDescuento.Text = "";
                    desbloquear(false);
                    btnEliminar.Enabled = false;
                    txtDocumento.Text = "";
                    cmbProv.Text = "";
                    cmbTipo.Text = "";
                    cmbEstado.Text = "";
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();



            }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.Text != "" && TxtPrecio.Text != "" && txtCantidad.Text != "" && txtDescuento.Text != "")
            {
                try
                {
                    SqlCommand comando = new SqlCommand("execute spDeleteCompraDetalle " + compraID + "," + cmbArticulos.Text + "", con.conectar);
                    con.abrir();
                    comando.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("Articulo Eliminado");
                    MostrarComprasDatos();
                    Total();
                    cmbArticulos.Text = "";
                    TxtPrecio.Text = "";
                    txtCantidad.Text = "";
                    txtDescuento.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }


            }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS"); };
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = Int32.Parse(dataGridView1.CurrentRow.Index.ToString());

                cmbArticulos.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                txtCantidad.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                TxtPrecio.Text = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                txtDescuento.Text = dataGridView1.Rows[fila].Cells[5].Value.ToString();
                btnEliminar.Enabled = true;
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex); }
        }
        public void Total() {
            try
            {
                SqlCommand comando = new SqlCommand("select dbo.TotalCompra (" + compraID + ")", con.conectar);
                con.abrir();
                txtTotal.Text= comando.ExecuteScalar().ToString();
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btnactcompra_Click(object sender, EventArgs e)
        {
            String tipo = "";
            String estado = "";
            if (cmbTipo.Text == "CREDITO") { tipo = "C"; }
            if (cmbTipo.Text == "CONTADO") { tipo = "R"; }
            if (cmbEstado.Text == "FACTURADO") { estado = "F"; }
            if (cmbEstado.Text == "PAGADO") { estado = "P"; }

            try {
                SqlCommand comando = new SqlCommand("execute spUpdateCompra @ID,@proveedor,@doc,@tipo,@estado ", con.conectar);
                comando.Parameters.AddWithValue("@ID", compraID.ToString());
                comando.Parameters.AddWithValue("@proveedor", cmbProv.Text);
                comando.Parameters.AddWithValue("@doc", txtDocumento.Text);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@estado", estado);
                con.abrir();
                comando.ExecuteNonQuery();
                con.close();
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
            }
            catch (Exception ex) {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cmbArticulos.Text = "";
            TxtPrecio.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "";
            desbloquear(false);
            btnEliminar.Enabled = false;
            txtDocumento.Text = "";
            cmbProv.Text = "";
            cmbTipo.Text = "";
            cmbEstado.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String articulo = "", cantidad = "", precio = "", descuento = "";
                int fila = Int32.Parse(dataGridView1.CurrentRow.Index.ToString());
                articulo = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                cantidad = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                precio = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                descuento = dataGridView1.Rows[fila].Cells[5].Value.ToString();

                SqlCommand comando = new SqlCommand("execute spUpdateCompraDetalle @ID,@art,@cant,@precio,@desc", con.conectar);
                comando.Parameters.AddWithValue("@ID", compraID.ToString());
                comando.Parameters.AddWithValue("@art", articulo);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@desc", descuento);

                con.abrir();
                comando.ExecuteNonQuery();
                con.close();
                MostrarComprasDatos();
                Total();
                cmbArticulos.Text = "";
                TxtPrecio.Text = "";
                txtCantidad.Text = "";
                txtDescuento.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
    }
}
