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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }
        conexion con = new conexion();
        int compra = 0;

        private void btnINGRESARPRODUCTOS_Click(object sender, EventArgs e)
        {


            if (txtcompra.Text != "" && cmbarticulo.Text != "" && txtCantidad.Text != "" )
            {
                int comprobar = -1;
                try
                {
                    SqlCommand comando = new SqlCommand("select dbo.comprobar("+compra+","+cmbarticulo.Text+","+txtCantidad.Text+",'"+fecha+"')", con.conectar);
                    con.abrir();
                    comprobar = Int32.Parse(comando.ExecuteScalar().ToString());
                    con.close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
                if (comprobar == 2)
                {
                    MessageBox.Show("PRODUCTO VENCIDO");
                }
                else {

                    if (comprobar==0) {
                        MessageBox.Show("CANTIDAD NO COINCIDE CON LA COMPRA \n SI DESEA ASEPTARLO PRECIONE EL BOTON CONSTANCIA \n DE LO CONTRARIO EN CANELAR");
                    }
                    else
                    {
                        try
                        {
                            SqlCommand comando = new SqlCommand("EXECUTE spInsertIngreso "+compra+","+cmbarticulo.Text+ "," + txtCantidad.Text + ",'" + fecha + "',1", con.conectar);
                            con.abrir();
                            comando.ExecuteNonQuery();
                            con.close();
                            MessageBox.Show("PRODUCTO INGRESADO");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex);
                        }

                    }
                
                }

            }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS"); };
        }

        private void txtcompra_Leave(object sender, EventArgs e)
        {
            int existencias = 0;
            try {
                compra = Int32.Parse(txtcompra.Text);
            }
            catch { compra = 0; }
            try
            {
                SqlCommand comando = new SqlCommand("select dbo.ExisteCompra (" + compra + ")", con.conectar);
                con.abrir();
                existencias = Int32.Parse(comando.ExecuteScalar().ToString());
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            if (existencias == 0)
            {
                MessageBox.Show("LA COMPRA NO EXISTE"); desbloquear(false);
            }
            else { desbloquear(true); llenarart(); cmbarticulo.Focus(); }
        }
        public void desbloquear(Boolean resp) {
            cmbarticulo.Enabled = resp;
            txtCantidad.Enabled = resp;
            monthCalendar1.Enabled = resp;
        }

        public void llenarart() { 
            cmbarticulo.DataSource = null;
            cmbarticulo.Items.Clear();
            SqlCommand comando = new SqlCommand("execute spSelectCompraDetalle "+ compra + "", con.conectar);

            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                cmbarticulo.Items.Add(Registro["ArticuloID"].ToString());
            }

            con.close();

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        string fecha = "";

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string[] temp = monthCalendar1.SelectionRange.End.ToShortDateString().Split('/');
            fecha = temp[2] + "-" + temp[1] + "-" + temp[0];
        }
    }
}
