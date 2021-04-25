
namespace Proyecto
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbCLIENTE = new System.Windows.Forms.ComboBox();
            this.cmbTIPOVENTA = new System.Windows.Forms.ComboBox();
            this.cmbPAGO = new System.Windows.Forms.ComboBox();
            this.lblPAGO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVENTA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDESCUENTO = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.cmbARTICULO = new System.Windows.Forms.ComboBox();
            this.btnINGRESARPRODUCTOS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtCANTIDAD = new System.Windows.Forms.ComboBox();
            this.lblexist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(24, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 16);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID CLIENTE";
            // 
            // cmbCLIENTE
            // 
            this.cmbCLIENTE.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCLIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCLIENTE.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCLIENTE.FormattingEnabled = true;
            this.cmbCLIENTE.Location = new System.Drawing.Point(24, 40);
            this.cmbCLIENTE.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCLIENTE.Name = "cmbCLIENTE";
            this.cmbCLIENTE.Size = new System.Drawing.Size(88, 25);
            this.cmbCLIENTE.TabIndex = 13;
            this.cmbCLIENTE.SelectedIndexChanged += new System.EventHandler(this.Ventas_Load);
            // 
            // cmbTIPOVENTA
            // 
            this.cmbTIPOVENTA.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTIPOVENTA.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTIPOVENTA.FormattingEnabled = true;
            this.cmbTIPOVENTA.Items.AddRange(new object[] {
            "AL POR MAYOR",
            "DETALLE"});
            this.cmbTIPOVENTA.Location = new System.Drawing.Point(136, 40);
            this.cmbTIPOVENTA.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTIPOVENTA.Name = "cmbTIPOVENTA";
            this.cmbTIPOVENTA.Size = new System.Drawing.Size(152, 25);
            this.cmbTIPOVENTA.TabIndex = 15;
            // 
            // cmbPAGO
            // 
            this.cmbPAGO.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPAGO.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPAGO.FormattingEnabled = true;
            this.cmbPAGO.Items.AddRange(new object[] {
            "CREDITO",
            "CONTADO"});
            this.cmbPAGO.Location = new System.Drawing.Point(312, 40);
            this.cmbPAGO.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPAGO.Name = "cmbPAGO";
            this.cmbPAGO.Size = new System.Drawing.Size(104, 25);
            this.cmbPAGO.TabIndex = 16;
            // 
            // lblPAGO
            // 
            this.lblPAGO.AutoSize = true;
            this.lblPAGO.BackColor = System.Drawing.Color.Transparent;
            this.lblPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAGO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPAGO.Location = new System.Drawing.Point(328, 16);
            this.lblPAGO.Name = "lblPAGO";
            this.lblPAGO.Size = new System.Drawing.Size(72, 16);
            this.lblPAGO.TabIndex = 17;
            this.lblPAGO.Text = "PAGO AL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "TIPO DE VENTA";
            // 
            // btnVENTA
            // 
            this.btnVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVENTA.Location = new System.Drawing.Point(446, 28);
            this.btnVENTA.Name = "btnVENTA";
            this.btnVENTA.Size = new System.Drawing.Size(143, 36);
            this.btnVENTA.TabIndex = 19;
            this.btnVENTA.Text = "NUEVA VENTA";
            this.btnVENTA.UseVisualStyleBackColor = true;
            this.btnVENTA.Click += new System.EventHandler(this.BtnVENTA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "ARTICULO ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(146, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "CANTIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(242, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "DESCUENTO";
            // 
            // txtDESCUENTO
            // 
            this.txtDESCUENTO.Enabled = false;
            this.txtDESCUENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDESCUENTO.Location = new System.Drawing.Point(242, 120);
            this.txtDESCUENTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDESCUENTO.Multiline = true;
            this.txtDESCUENTO.Name = "txtDESCUENTO";
            this.txtDESCUENTO.Size = new System.Drawing.Size(104, 24);
            this.txtDESCUENTO.TabIndex = 42;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCANCELAR.Enabled = false;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCANCELAR.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCANCELAR.Location = new System.Drawing.Point(604, 28);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(128, 36);
            this.btnCANCELAR.TabIndex = 45;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click_1);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnELIMINAR.Enabled = false;
            this.btnELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnELIMINAR.Location = new System.Drawing.Point(490, 115);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(107, 32);
            this.btnELIMINAR.TabIndex = 46;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.BtnELIMINAR_Click);
            // 
            // cmbARTICULO
            // 
            this.cmbARTICULO.BackColor = System.Drawing.SystemColors.Window;
            this.cmbARTICULO.Enabled = false;
            this.cmbARTICULO.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbARTICULO.FormattingEnabled = true;
            this.cmbARTICULO.Location = new System.Drawing.Point(26, 120);
            this.cmbARTICULO.Margin = new System.Windows.Forms.Padding(2);
            this.cmbARTICULO.Name = "cmbARTICULO";
            this.cmbARTICULO.Size = new System.Drawing.Size(96, 25);
            this.cmbARTICULO.TabIndex = 47;
            this.cmbARTICULO.SelectedIndexChanged += new System.EventHandler(this.cmbARTICULO_SelectedIndexChanged);
            // 
            // btnINGRESARPRODUCTOS
            // 
            this.btnINGRESARPRODUCTOS.Enabled = false;
            this.btnINGRESARPRODUCTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnINGRESARPRODUCTOS.Location = new System.Drawing.Point(357, 115);
            this.btnINGRESARPRODUCTOS.Name = "btnINGRESARPRODUCTOS";
            this.btnINGRESARPRODUCTOS.Size = new System.Drawing.Size(128, 32);
            this.btnINGRESARPRODUCTOS.TabIndex = 48;
            this.btnINGRESARPRODUCTOS.Text = "INGRESAR";
            this.btnINGRESARPRODUCTOS.UseVisualStyleBackColor = true;
            this.btnINGRESARPRODUCTOS.Click += new System.EventHandler(this.BtnINGRESARPRODUCTOS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(9, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 76);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(388, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "VENTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(366, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "DETALLE VENTA";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.Location = new System.Drawing.Point(83, 285);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(620, 218);
            this.dataGridView2.TabIndex = 55;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Enabled = false;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnlimpiar.Location = new System.Drawing.Point(604, 115);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(128, 32);
            this.btnlimpiar.TabIndex = 57;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.BackColor = System.Drawing.SystemColors.Window;
            this.txtCANTIDAD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCANTIDAD.FormattingEnabled = true;
            this.txtCANTIDAD.Location = new System.Drawing.Point(136, 120);
            this.txtCANTIDAD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(88, 25);
            this.txtCANTIDAD.TabIndex = 58;
            // 
            // lblexist
            // 
            this.lblexist.AutoSize = true;
            this.lblexist.BackColor = System.Drawing.Color.Transparent;
            this.lblexist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblexist.Location = new System.Drawing.Point(121, 147);
            this.lblexist.Name = "lblexist";
            this.lblexist.Size = new System.Drawing.Size(0, 16);
            this.lblexist.TabIndex = 59;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(801, 570);
            this.Controls.Add(this.lblexist);
            this.Controls.Add(this.txtCANTIDAD);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnINGRESARPRODUCTOS);
            this.Controls.Add(this.cmbARTICULO);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDESCUENTO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVENTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPAGO);
            this.Controls.Add(this.cmbPAGO);
            this.Controls.Add(this.cmbTIPOVENTA);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbCLIENTE);
            this.Name = "Ventas";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbCLIENTE;
        private System.Windows.Forms.ComboBox cmbTIPOVENTA;
        private System.Windows.Forms.ComboBox cmbPAGO;
        private System.Windows.Forms.Label lblPAGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVENTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDESCUENTO;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.ComboBox cmbARTICULO;
        private System.Windows.Forms.Button btnINGRESARPRODUCTOS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ComboBox txtCANTIDAD;
        private System.Windows.Forms.Label lblexist;
    }
}