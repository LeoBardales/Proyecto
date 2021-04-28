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
    public partial class ElaboracionProductos : Form
    {
        public ElaboracionProductos()
        {
            InitializeComponent();
        }

        conexion con = new conexion();
        private void CmbPRODUCTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrandoExistencias();
            
        }

        private void ElaboracionProductos_Load(object sender, EventArgs e)
        {
            CargandoArticulos();
            txtEXISTENCIA.Enabled = false;
            txtSTOCK.Enabled = false;
            btnCONFIRMAR.Enabled = false;
            
        }

        public void CargandoArticulos()
        {
            SqlCommand comando = new SqlCommand("select *from dbo.Articulos", con.conectar);

            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            while (Registro.Read())
            {
                cmbPRODUCTO.Items.Add(Registro["nombre"].ToString());
                cmbPAI.Items.Add(Registro["nombre"].ToString());

            }

            con.close();
        }

        public void MostrandoExistencias(){
            
            String producto = cmbPRODUCTO.Text;
            
            SqlCommand comando = new SqlCommand("select dbo.IdArticuloNombre ('"+producto+"') as ex", con.conectar);
            con.abrir();
            comando.ExecuteNonQuery();
            SqlDataReader Registro = comando.ExecuteReader();
            Registro.Read();
            txtEXISTENCIA.Text = Registro["ex"].ToString(); 
            con.close();

            SqlCommand comando2 = new SqlCommand("select dbo.StockNombre ('" + producto + "') as stock", con.conectar);
            con.abrir();
            comando2.ExecuteNonQuery();
            SqlDataReader Registro2 = comando2.ExecuteReader();
            Registro2.Read();
            txtSTOCK.Text = Registro2["stock"].ToString();
            con.close();

        }


        private void BtnAGREGAR_Click(object sender, EventArgs e)
        {
            int cant = 0;
            int exist = 0;
            if (txtCANTIDAD.Text != "") {
                cant = Int32.Parse(txtCANTIDAD.Text);
                exist = Int32.Parse(txtEXISTENCIA.Text);
                if (cant < exist)
                {
                    DataGridProductos.Rows.Add(cmbPRODUCTO.Text, txtCANTIDAD.Text);
                }
                else { MessageBox.Show("No sea MAJE no tendra existencias"); }
            }
            else { MessageBox.Show("No sea MAJE ingrese una cantidad"); }
            
            btnCONFIRMAR.Enabled = true;
           
        }

        private void BtnCONFIRMAR_Click(object sender, EventArgs e)
        {   
            int i;
            String producto = "";
            int cantidad = 0;
            int cuenta = DataGridProductos.Rows.Count - 1;
            for (i = 0; i < cuenta; i++)
            {
                               
                    producto = DataGridProductos.Rows[i].Cells[0].Value.ToString();
                    cantidad = Int32.Parse(DataGridProductos.Rows[i].Cells[1].Value.ToString());

                    int resta = Int32.Parse(txtEXISTENCIA.Text) - Int32.Parse(txtCANTIDAD.Text);


                MessageBox.Show(resta.ToString());

                SqlCommand comando = new SqlCommand("select dbo.IDNombre ('" + producto + "') as ID", con.conectar);
                con.abrir();
                comando.ExecuteNonQuery();
                SqlDataReader Registro = comando.ExecuteReader();
                Registro.Read();
                String id = Registro["ID"].ToString();
                con.close();
                MessageBox.Show(id.ToString());

                SqlCommand comando2 = new SqlCommand("execute spUpdateExistencias " + id + "," + resta + "", con.conectar);
                con.abrir();
                comando2.ExecuteNonQuery();
                con.close();


            }

            String producto2 = "";

            producto2 = cmbPAI.Text;

            SqlCommand comando3 = new SqlCommand("select dbo.IDNombre ('" + producto2 + "') as ID", con.conectar);
            con.abrir();
            comando3.ExecuteNonQuery();
            SqlDataReader Registro3 = comando3.ExecuteReader();
            Registro3.Read();
            String id2 = Registro3["ID"].ToString();
            con.close();

            SqlCommand comando4 = new SqlCommand("select dbo.IdArticuloNombre ('" + producto2 + "') as ex", con.conectar);
            con.abrir();
            comando4.ExecuteNonQuery();
            SqlDataReader Registro4 = comando4.ExecuteReader();
            Registro4.Read();
            int cant2 = Int32.Parse(Registro4["ex"].ToString());
            con.close();

            int cantidad2 = 0;
            cantidad2 = Int32.Parse(txtCAI.Text);

            int suma = cant2 + cantidad2;

            SqlCommand comando5 = new SqlCommand("execute spUpdateExistencias " + id2 + "," + suma + "", con.conectar);
            con.abrir();
            comando5.ExecuteNonQuery();
            con.close();


            DataGridProductos.Rows.Clear();
            cmbPRODUCTO.Text = "";
            txtCANTIDAD.Text = "";
            txtEXISTENCIA.Text = "";
            txtSTOCK.Text = "";
            txtCAI.Text = "";
            cmbPAI.Text = "";
        }
    }
            
    
}
