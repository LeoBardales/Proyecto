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
                        MessageBox.Show("CANTIDAD NO COINCIDE CON LA COMPRA \nSI DESEA ACEPTARLO PRECIONE EL BOTON CONSTANCIA \nDE LO CONTRARIO EN CANELAR");
                        btnConstancia.Enabled = true;
                    }
                    else
                    {
                        try
                        {
                            SqlCommand comando = new SqlCommand("EXECUTE spInsertIngreso "+compra+","+cmbarticulo.Text+ "," + txtCantidad.Text + ",'" + fecha + "',1", con.conectar);
                            con.abrir();
                            comando.ExecuteNonQuery();
                            con.close();
                            desbloquear(false);
                            limpiar();
                            btnConstancia.Enabled = false;
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
        public void limpiar() {
            txtCantidad.Text = "";
            txtcompra.Text = "";
            cmbarticulo.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnConstancia.Enabled = false;
            desbloquear(false);
            limpiar();
            txtConstancia.Visible = false;
            btnguardar.Visible = false;
        }

        private void btnConstancia_Click(object sender, EventArgs e)
        {
            txtConstancia.Visible = true;
            btnguardar.Visible = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtcompra.Text != "" && cmbarticulo.Text != "" && txtCantidad.Text != "" && txtConstancia.Text!="")
            {
               
                int comprobar = -1;
                try
                {
                    SqlCommand comando = new SqlCommand("select dbo.comprobar(" + compra + "," + cmbarticulo.Text + "," + txtCantidad.Text + ",'" + fecha + "')", con.conectar);
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
                else
                {

                    
                        try
                        {
                            SqlCommand comando = new SqlCommand("EXECUTE spInsertConstancia @compra,@art,@cant,@fecha,1,@obs", con.conectar);
                            comando.Parameters.AddWithValue("@compra", compra);
                            comando.Parameters.AddWithValue("@art", cmbarticulo.Text);
                            comando.Parameters.AddWithValue("@cant", txtCantidad.Text);
                            comando.Parameters.AddWithValue("@fecha", fecha);
                            comando.Parameters.AddWithValue("@obs", txtConstancia.Text);
                        con.abrir();
                            comando.ExecuteNonQuery();
                            con.close();
                            btnConstancia.Enabled = false;
                            desbloquear(false);
                            limpiar();
                            txtConstancia.Visible = false;
                            btnguardar.Visible = false;
                        MessageBox.Show("PRODUCTO INGRESADO");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex);
                        }

                    

                }

            }
            else { MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS"); };

        }
    }
}
