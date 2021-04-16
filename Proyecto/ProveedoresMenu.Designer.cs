
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
            this.SuspendLayout();
            // 
            // Proveedores
            // 
            this.Proveedores.Location = new System.Drawing.Point(8, 16);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(112, 56);
            this.Proveedores.TabIndex = 0;
            this.Proveedores.Text = "PROVEEDORES";
            this.Proveedores.UseVisualStyleBackColor = true;
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // ComprasMenu
            // 
            this.ClientSize = new System.Drawing.Size(356, 261);
            this.Controls.Add(this.Proveedores);
            this.Name = "ComprasMenu";
            this.Text = "DEPARTAMENTO DE COMPRAS";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Proveedores;
    }
}