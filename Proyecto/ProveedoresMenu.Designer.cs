
namespace Proyecto
{
    partial class ComprasMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Proveedores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Proveedores
            // 
            this.Proveedores.Location = new System.Drawing.Point(8, 16);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(132, 56);
            this.Proveedores.TabIndex = 0;
            this.Proveedores.Text = "PROVEEDORES";
            this.Proveedores.UseVisualStyleBackColor = true;
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "COMPRA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "ARTICULOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "EXTENDER CHEQUE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ComprasMenu
            // 
            this.ClientSize = new System.Drawing.Size(356, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Proveedores);
            this.Name = "ComprasMenu";
            this.Text = "DEPARTAMENTO DE COMPRAS";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Proveedores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}