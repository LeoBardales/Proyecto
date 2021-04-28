
namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClienteMes = new System.Windows.Forms.Button();
            this.btnsaldo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienteMes
            // 
            this.btnClienteMes.Location = new System.Drawing.Point(26, 23);
            this.btnClienteMes.Name = "btnClienteMes";
            this.btnClienteMes.Size = new System.Drawing.Size(140, 57);
            this.btnClienteMes.TabIndex = 17;
            this.btnClienteMes.Text = "COMPRAS";
            this.btnClienteMes.UseVisualStyleBackColor = true;
            this.btnClienteMes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsaldo
            // 
            this.btnsaldo.Location = new System.Drawing.Point(239, 23);
            this.btnsaldo.Name = "btnsaldo";
            this.btnsaldo.Size = new System.Drawing.Size(140, 57);
            this.btnsaldo.TabIndex = 18;
            this.btnsaldo.Text = "VENTAS";
            this.btnsaldo.UseVisualStyleBackColor = true;
            this.btnsaldo.Click += new System.EventHandler(this.btnsaldo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "BODEGA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsaldo);
            this.Controls.Add(this.btnClienteMes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClienteMes;
        private System.Windows.Forms.Button btnsaldo;
        private System.Windows.Forms.Button button1;
    }
}

