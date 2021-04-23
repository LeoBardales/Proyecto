
namespace Proyecto
{
    partial class VentasMenu
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.VENTAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(9, 10);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(94, 41);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // VENTAS
            // 
            this.VENTAS.Location = new System.Drawing.Point(120, 8);
            this.VENTAS.Margin = new System.Windows.Forms.Padding(2);
            this.VENTAS.Name = "VENTAS";
            this.VENTAS.Size = new System.Drawing.Size(94, 41);
            this.VENTAS.TabIndex = 1;
            this.VENTAS.Text = "VENTAS";
            this.VENTAS.UseVisualStyleBackColor = true;
            this.VENTAS.Click += new System.EventHandler(this.VENTAS_Click);
            // 
            // VentasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 257);
            this.Controls.Add(this.VENTAS);
            this.Controls.Add(this.btnClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentasMenu";
            this.Text = "DEPARTAMENTOS DE VENTAS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button VENTAS;
    }
}