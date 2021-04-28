
namespace Proyecto
{
    partial class ElaboracionProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElaboracionProductos));
            this.label2 = new System.Windows.Forms.Label();
            this.lblPAGO = new System.Windows.Forms.Label();
            this.cmbPRODUCTO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataGridProductos = new System.Windows.Forms.DataGridView();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnCONFIRMAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.txtEXISTENCIA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSTOCK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCAI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPAI = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "PRODUCTO";
            // 
            // lblPAGO
            // 
            this.lblPAGO.AutoSize = true;
            this.lblPAGO.BackColor = System.Drawing.Color.Transparent;
            this.lblPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAGO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPAGO.Location = new System.Drawing.Point(160, 56);
            this.lblPAGO.Name = "lblPAGO";
            this.lblPAGO.Size = new System.Drawing.Size(85, 16);
            this.lblPAGO.TabIndex = 21;
            this.lblPAGO.Text = "CANTIDAD";
            // 
            // cmbPRODUCTO
            // 
            this.cmbPRODUCTO.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPRODUCTO.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPRODUCTO.FormattingEnabled = true;
            this.cmbPRODUCTO.Location = new System.Drawing.Point(16, 80);
            this.cmbPRODUCTO.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPRODUCTO.Name = "cmbPRODUCTO";
            this.cmbPRODUCTO.Size = new System.Drawing.Size(136, 25);
            this.cmbPRODUCTO.TabIndex = 19;
            this.cmbPRODUCTO.SelectedIndexChanged += new System.EventHandler(this.CmbPRODUCTO_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(352, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "PRODUCTOS";
            // 
            // DataGridProductos
            // 
            this.DataGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridProductos.ColumnHeadersHeight = 30;
            this.DataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCTO,
            this.CANTIDAD});
            this.DataGridProductos.EnableHeadersVisualStyles = false;
            this.DataGridProductos.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridProductos.Location = new System.Drawing.Point(288, 80);
            this.DataGridProductos.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridProductos.Name = "DataGridProductos";
            this.DataGridProductos.RowHeadersVisible = false;
            this.DataGridProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridProductos.RowTemplate.Height = 24;
            this.DataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridProductos.Size = new System.Drawing.Size(224, 144);
            this.DataGridProductos.TabIndex = 55;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.Width = 115;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 109;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAGREGAR.Location = new System.Drawing.Point(16, 184);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(264, 40);
            this.btnAGREGAR.TabIndex = 57;
            this.btnAGREGAR.Text = "AGREGAR PRODUCTO";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.BtnAGREGAR_Click);
            // 
            // btnCONFIRMAR
            // 
            this.btnCONFIRMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCONFIRMAR.Location = new System.Drawing.Point(128, 376);
            this.btnCONFIRMAR.Name = "btnCONFIRMAR";
            this.btnCONFIRMAR.Size = new System.Drawing.Size(264, 40);
            this.btnCONFIRMAR.TabIndex = 58;
            this.btnCONFIRMAR.Text = "CONFIRMAR";
            this.btnCONFIRMAR.UseVisualStyleBackColor = true;
            this.btnCONFIRMAR.Click += new System.EventHandler(this.BtnCONFIRMAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCANCELAR.Location = new System.Drawing.Point(128, 424);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(264, 40);
            this.btnCANCELAR.TabIndex = 59;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(160, 80);
            this.txtCANTIDAD.Multiline = true;
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(116, 24);
            this.txtCANTIDAD.TabIndex = 60;
            // 
            // txtEXISTENCIA
            // 
            this.txtEXISTENCIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEXISTENCIA.Location = new System.Drawing.Point(16, 144);
            this.txtEXISTENCIA.Multiline = true;
            this.txtEXISTENCIA.Name = "txtEXISTENCIA";
            this.txtEXISTENCIA.Size = new System.Drawing.Size(100, 24);
            this.txtEXISTENCIA.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "EXISTENCIA";
            // 
            // txtSTOCK
            // 
            this.txtSTOCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTOCK.Location = new System.Drawing.Point(160, 144);
            this.txtSTOCK.Multiline = true;
            this.txtSTOCK.Name = "txtSTOCK";
            this.txtSTOCK.Size = new System.Drawing.Size(116, 24);
            this.txtSTOCK.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(160, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "STOCK MINIMO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(152, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 31);
            this.label4.TabIndex = 65;
            this.label4.Text = "MATERIA PRIMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(64, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 31);
            this.label5.TabIndex = 66;
            this.label5.Text = "PRODUCTO A INGRESAR";
            // 
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(272, 336);
            this.txtCAI.Multiline = true;
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.Size = new System.Drawing.Size(116, 24);
            this.txtCAI.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(128, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "PRODUCTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(272, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "CANTIDAD";
            // 
            // cmbPAI
            // 
            this.cmbPAI.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPAI.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPAI.FormattingEnabled = true;
            this.cmbPAI.Location = new System.Drawing.Point(128, 336);
            this.cmbPAI.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPAI.Name = "cmbPAI";
            this.cmbPAI.Size = new System.Drawing.Size(136, 25);
            this.cmbPAI.TabIndex = 67;
            // 
            // ElaboracionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(524, 426);
            this.Controls.Add(this.txtCAI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPAI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSTOCK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEXISTENCIA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCANTIDAD);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnCONFIRMAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataGridProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPAGO);
            this.Controls.Add(this.cmbPRODUCTO);
            this.Name = "ElaboracionProductos";
            this.Text = "ElaboracionProductos";
            this.Load += new System.EventHandler(this.ElaboracionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPAGO;
        private System.Windows.Forms.ComboBox cmbPRODUCTO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataGridProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnCONFIRMAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.TextBox txtEXISTENCIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSTOCK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCAI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPAI;
    }
}