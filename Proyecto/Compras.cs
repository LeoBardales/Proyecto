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
            MostrarComprasDatos();
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
            if (txtDocumento.Text != "" && cmbTipo.Text != "" && cmbEstado.Text != "" && cmbProv.Text != "") { llenarArt(); desbloquear(true); }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS");};
            
        }
        public void MostrarComprasDatos()
        {
            SqlDataAdapter datos = new SqlDataAdapter("select *from CompraActual(1)", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void desbloquear(Boolean opc) {
            btnCancelar.Enabled = opc;
            cmbArticulos.Enabled = opc;
            txtDocumento.Enabled = !opc;
            cmbTipo.Enabled = !opc;
            cmbEstado.Enabled = !opc;
            cmbProv.Enabled = !opc;
            btnCrear.Enabled = !opc;
            btnAgregar.Enabled = opc;
            TxtPrecio.Enabled = opc;
            txtCantidad.Enabled = opc;
            txtDescuento.Enabled = opc;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.Text != "" && TxtPrecio.Text != "" && txtCantidad.Text!="" && txtDescuento.Text!="") { MostrarComprasDatos(); }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS"); };
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int fila = Int32.Parse(dataGridView1.CurrentRow.Index.ToString());

            cmbArticulos.Text=dataGridView1.Rows[fila].Cells[0].Value.ToString();
            txtCantidad.Text= dataGridView1.Rows[fila].Cells[2].Value.ToString();
            TxtPrecio.Text= dataGridView1.Rows[fila].Cells[3].Value.ToString();
            txtDescuento.Text= dataGridView1.Rows[fila].Cells[4].Value.ToString();
            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.Text != "" && TxtPrecio.Text != "" && txtCantidad.Text != "" && txtDescuento.Text != "") { MessageBox.Show("Listo"); }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS"); };
        }
    }
}
