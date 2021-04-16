
namespace Proyecto
{
    partial class Proveedores
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
            this.MostrarDatos = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.lblRTN = new System.Windows.Forms.Label();
            this.lblCONTACTO = new System.Windows.Forms.Label();
            this.lblTELEFONO = new System.Windows.Forms.Label();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.txtCONTACTO = new System.Windows.Forms.TextBox();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.Anterior = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtLIMITE = new System.Windows.Forms.TextBox();
            this.txtSALDO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MostrarDatos
            // 
            this.MostrarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarDatos.Location = new System.Drawing.Point(568, 72);
            this.MostrarDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MostrarDatos.Name = "MostrarDatos";
            this.MostrarDatos.Size = new System.Drawing.Size(116, 37);
            this.MostrarDatos.TabIndex = 0;
            this.MostrarDatos.Text = "Mostrar Datos";
            this.MostrarDatos.UseVisualStyleBackColor = true;
            this.MostrarDatos.Click += new System.EventHandler(this.MostrarDatos_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(608, 18);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(88, 24);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(597, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(52, 27);
            this.txtID.TabIndex = 3;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOMBRE.Location = new System.Drawing.Point(160, 18);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNOMBRE.Multiline = true;
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(351, 22);
            this.txtNOMBRE.TabIndex = 4;
            // 
            // lblRTN
            // 
            this.lblRTN.AutoSize = true;
            this.lblRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTN.Location = new System.Drawing.Point(120, 52);
            this.lblRTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Size = new System.Drawing.Size(35, 15);
            this.lblRTN.TabIndex = 5;
            this.lblRTN.Text = "RTN";
            // 
            // lblCONTACTO
            // 
            this.lblCONTACTO.AutoSize = true;
            this.lblCONTACTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTO.Location = new System.Drawing.Point(78, 80);
            this.lblCONTACTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCONTACTO.Name = "lblCONTACTO";
            this.lblCONTACTO.Size = new System.Drawing.Size(79, 15);
            this.lblCONTACTO.TabIndex = 6;
            this.lblCONTACTO.Text = "CONTACTO";
            // 
            // lblTELEFONO
            // 
            this.lblTELEFONO.AutoSize = true;
            this.lblTELEFONO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTELEFONO.Location = new System.Drawing.Point(78, 108);
            this.lblTELEFONO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTELEFONO.Name = "lblTELEFONO";
            this.lblTELEFONO.Size = new System.Drawing.Size(79, 15);
            this.lblTELEFONO.TabIndex = 7;
            this.lblTELEFONO.Text = "TELEFONO";
            this.lblTELEFONO.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.AutoSize = true;
            this.lblEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMAIL.Location = new System.Drawing.Point(110, 135);
            this.lblEMAIL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(48, 15);
            this.lblEMAIL.TabIndex = 8;
            this.lblEMAIL.Text = "EMAIL";
            // 
            // txtRTN
            // 
            this.txtRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Location = new System.Drawing.Point(160, 46);
            this.txtRTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRTN.Multiline = true;
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(351, 22);
            this.txtRTN.TabIndex = 9;
            // 
            // txtCONTACTO
            // 
            this.txtCONTACTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCONTACTO.Location = new System.Drawing.Point(160, 74);
            this.txtCONTACTO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCONTACTO.Multiline = true;
            this.txtCONTACTO.Name = "txtCONTACTO";
            this.txtCONTACTO.Size = new System.Drawing.Size(351, 22);
            this.txtCONTACTO.TabIndex = 10;
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTELEFONO.Location = new System.Drawing.Point(160, 102);
            this.txtTELEFONO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTELEFONO.Multiline = true;
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(351, 22);
            this.txtTELEFONO.TabIndex = 11;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMAIL.Location = new System.Drawing.Point(160, 128);
            this.txtEMAIL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEMAIL.Multiline = true;
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(351, 22);
            this.txtEMAIL.TabIndex = 12;
            // 
            // Anterior
            // 
            this.Anterior.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anterior.Location = new System.Drawing.Point(568, 120);
            this.Anterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(112, 32);
            this.Anterior.TabIndex = 13;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = false;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siguiente.Location = new System.Drawing.Point(568, 160);
            this.Siguiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(112, 32);
            this.Siguiente.TabIndex = 14;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = false;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(208, 176);
            this.lblLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(56, 16);
            this.lblLimite.TabIndex = 15;
            this.lblLimite.Text = "LIMITE";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(360, 176);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(52, 15);
            this.lblSaldo.TabIndex = 16;
            this.lblSaldo.Text = "SALDO";
            this.lblSaldo.Click += new System.EventHandler(this.LblSaldo_Click);
            // 
            // txtLIMITE
            // 
            this.txtLIMITE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLIMITE.Location = new System.Drawing.Point(184, 192);
            this.txtLIMITE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLIMITE.Multiline = true;
            this.txtLIMITE.Name = "txtLIMITE";
            this.txtLIMITE.Size = new System.Drawing.Size(105, 24);
            this.txtLIMITE.TabIndex = 17;
            this.txtLIMITE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSALDO
            // 
            this.txtSALDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSALDO.Location = new System.Drawing.Point(336, 192);
            this.txtSALDO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSALDO.Multiline = true;
            this.txtSALDO.Name = "txtSALDO";
            this.txtSALDO.Size = new System.Drawing.Size(105, 24);
            this.txtSALDO.TabIndex = 18;
            this.txtSALDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 234);
            this.Controls.Add(this.txtSALDO);
            this.Controls.Add(this.txtLIMITE);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtTELEFONO);
            this.Controls.Add(this.txtCONTACTO);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.lblEMAIL);
            this.Controls.Add(this.lblTELEFONO);
            this.Controls.Add(this.lblCONTACTO);
            this.Controls.Add(this.lblRTN);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.MostrarDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Proveedores";
            this.Text = "DATOS DE PROVEEDORES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarDatos;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label lblRTN;
        private System.Windows.Forms.Label lblCONTACTO;
        private System.Windows.Forms.Label lblTELEFONO;
        private System.Windows.Forms.Label lblEMAIL;
        private System.Windows.Forms.TextBox txtRTN;
        private System.Windows.Forms.TextBox txtCONTACTO;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Siguiente;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtLIMITE;
        private System.Windows.Forms.TextBox txtSALDO;
    }
}