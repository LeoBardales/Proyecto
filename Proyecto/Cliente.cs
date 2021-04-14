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
    public partial class Cliente : Form
    {
        conexion con = new conexion();
        public Cliente()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Limpiar();
            String id;
            id = TxtID.Text;
            SqlCommand comando = new SqlCommand("select *from SaldoCliente(@ID)", con.conectar);
            comando.Parameters.AddWithValue("@ID", id);
            con.abrir();
            SqlDataReader Registro = comando.ExecuteReader();
            if (Registro.Read())
            {
                TxtNombre.Text = Registro["NOMBRE"].ToString();
                TxtTipo.Text = Registro["TIPO"].ToString();
                TxtDireccion.Text = Registro["DIRECCIÓN"].ToString();
                TxtEC.Text = Registro["ESTADO CIVIL"].ToString();
                TxtLimite.Text = Registro["LIMITE"].ToString();
                TxtSaldo.Text = Registro["SALDO"].ToString();
                TxtSexo.Text = Registro["SEXO"].ToString();
            }
            else {
                MessageBox.Show("NO EXISTE NINGUN CLIENTE CON ESE ID");
            }
            con.close();
        }

        public void Limpiar() {
            TxtNombre.Text = "";
            TxtTipo.Text = "";
            TxtDireccion.Text = "";
            TxtEC.Text = "";
            TxtLimite.Text = "";
            TxtSaldo.Text = "";
            TxtSexo.Text = "";
        }
    }
}
