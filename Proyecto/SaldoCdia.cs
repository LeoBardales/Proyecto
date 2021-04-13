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
    
    public partial class SaldoCdia : Form
    {
        String mes = "MONTH(GETDATE())";
        String ano = "YEAR(GETDATE())";
        conexion con = new conexion();
        public SaldoCdia()
        {
            InitializeComponent();
            dataGridView1.DataSource = MostrarDatos(mes,ano);
            llenarcmd();


        }

        public void llenarcmd() {
            for (int i = 2020; i <= 2120; i++) {
                cmdano.Items.Add(i.ToString());
            
            }
        }

        private void SaldoCdia_Load(object sender, EventArgs e)
        {

        }
        public DataTable MostrarDatos(String cadena1, String cadena2)
        {
            SqlDataAdapter datos = new SqlDataAdapter("select *from SaldoClienteMes("+cadena1+ "," + cadena2 + ")", con.conectar);
            DataTable dt = new DataTable();
            datos.Fill(dt);
            return dt;
        }

        //pruebab
        private void cmbmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int prueba = cmbmes.SelectedIndex;
            prueba += 1;
            mes = prueba.ToString();
            dataGridView1.DataSource = MostrarDatos(mes,ano);
        }

        private void cmdano_SelectedIndexChanged(object sender, EventArgs e)
        {
            String an = cmdano.Text;
            ano = an;
            dataGridView1.DataSource = MostrarDatos(mes, ano);
        }
    }

}
