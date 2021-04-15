using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class Form1 : Form
    {
        //prueba
        //otra prueba
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
         


        }

     
        
        private void button1_Click(object sender, EventArgs e)
        {
            ComprasMemu frm = new ComprasMemu();
            frm.Show();
        }

        private void btnsaldo_Click(object sender, EventArgs e)
        {
            VentasMenu cliente = new VentasMenu();
            cliente.Show();

        }
    }
}
