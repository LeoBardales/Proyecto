﻿using System;
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
    public partial class ComprasMenu : Form
    {
        public ComprasMenu()
        {
            InitializeComponent();
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.Show();
        }
    }
 }

