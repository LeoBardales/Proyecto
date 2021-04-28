
namespace Proyecto
{
    partial class PagoFactura
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
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.CLIENTEID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbcliente
            // 
            this.cmbcliente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(112, 2);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(169, 29);
            this.cmbcliente.TabIndex = 0;
            // 
            // CLIENTEID
            // 
            this.CLIENTEID.AutoSize = true;
            this.CLIENTEID.ForeColor = System.Drawing.Color.White;
            this.CLIENTEID.Location = new System.Drawing.Point(12, 9);
            this.CLIENTEID.Name = "CLIENTEID";
            this.CLIENTEID.Size = new System.Drawing.Size(78, 17);
            this.CLIENTEID.TabIndex = 1;
            this.CLIENTEID.Text = "CLIENTEID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "VALOR:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(112, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 30);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(112, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PagoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(358, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLIENTEID);
            this.Controls.Add(this.cmbcliente);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PagoFactura";
            this.Text = "PagoFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.Label CLIENTEID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}