
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblID.Location = new System.Drawing.Point(32, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 20);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID CLIENTE";
            // 
            // cmbCLIENTE
            // 
            this.cmbCLIENTE.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCLIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCLIENTE.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCLIENTE.FormattingEnabled = true;
            this.cmbCLIENTE.Location = new System.Drawing.Point(32, 49);
            this.cmbCLIENTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCLIENTE.Name = "cmbCLIENTE";
            this.cmbCLIENTE.Size = new System.Drawing.Size(116, 30);
            this.cmbCLIENTE.TabIndex = 13;
            // 
            // cmbTIPOVENTA
            // 
            this.cmbTIPOVENTA.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTIPOVENTA.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTIPOVENTA.FormattingEnabled = true;
            this.cmbTIPOVENTA.Items.AddRange(new object[] {
            "AL POR MAYOR",
            "AL DETALLE"});
            this.cmbTIPOVENTA.Location = new System.Drawing.Point(181, 49);
            this.cmbTIPOVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTIPOVENTA.Name = "cmbTIPOVENTA";
            this.cmbTIPOVENTA.Size = new System.Drawing.Size(201, 30);
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
            this.cmbPAGO.Location = new System.Drawing.Point(416, 49);
            this.cmbPAGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPAGO.Name = "cmbPAGO";
            this.cmbPAGO.Size = new System.Drawing.Size(137, 30);
            this.cmbPAGO.TabIndex = 16;
            // 
            // lblPAGO
            // 
            this.lblPAGO.AutoSize = true;
            this.lblPAGO.BackColor = System.Drawing.Color.Transparent;
            this.lblPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAGO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPAGO.Location = new System.Drawing.Point(437, 20);
            this.lblPAGO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPAGO.Name = "lblPAGO";
            this.lblPAGO.Size = new System.Drawing.Size(90, 20);
            this.lblPAGO.TabIndex = 17;
            this.lblPAGO.Text = "PAGO AL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(203, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "TIPO DE VENTA";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnVENTA
            // 
            this.btnVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVENTA.Location = new System.Drawing.Point(594, 35);
            this.btnVENTA.Margin = new System.Windows.Forms.Padding(4);
            this.btnVENTA.Name = "btnVENTA";
            this.btnVENTA.Size = new System.Drawing.Size(191, 44);
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
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "ARTICULO ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(194, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "CANTIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(322, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "DESCUENTO";
            // 
            // txtDESCUENTO
            // 
            this.txtDESCUENTO.Enabled = false;
            this.txtDESCUENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDESCUENTO.Location = new System.Drawing.Point(322, 148);
            this.txtDESCUENTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDESCUENTO.Multiline = true;
            this.txtDESCUENTO.Name = "txtDESCUENTO";
            this.txtDESCUENTO.Size = new System.Drawing.Size(137, 29);
            this.txtDESCUENTO.TabIndex = 42;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCANCELAR.Enabled = false;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCANCELAR.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCANCELAR.Location = new System.Drawing.Point(805, 35);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(170, 44);
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
            this.btnELIMINAR.Location = new System.Drawing.Point(654, 142);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(143, 39);
            this.btnELIMINAR.TabIndex = 46;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click_1);
            // 
            // cmbARTICULO
            // 
            this.cmbARTICULO.BackColor = System.Drawing.SystemColors.Window;
            this.cmbARTICULO.Enabled = false;
            this.cmbARTICULO.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbARTICULO.FormattingEnabled = true;
            this.cmbARTICULO.Location = new System.Drawing.Point(34, 148);
            this.cmbARTICULO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbARTICULO.Name = "cmbARTICULO";
            this.cmbARTICULO.Size = new System.Drawing.Size(127, 30);
            this.cmbARTICULO.TabIndex = 47;
            this.cmbARTICULO.SelectedIndexChanged += new System.EventHandler(this.cmbARTICULO_SelectedIndexChanged);
            // 
            // btnINGRESARPRODUCTOS
            // 
            this.btnINGRESARPRODUCTOS.Enabled = false;
            this.btnINGRESARPRODUCTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnINGRESARPRODUCTOS.Location = new System.Drawing.Point(476, 142);
            this.btnINGRESARPRODUCTOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnINGRESARPRODUCTOS.Name = "btnINGRESARPRODUCTOS";
            this.btnINGRESARPRODUCTOS.Size = new System.Drawing.Size(170, 39);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 94);
            this.dataGridView1.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(517, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "VENTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(488, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.Location = new System.Drawing.Point(111, 351);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(826, 268);
            this.dataGridView2.TabIndex = 55;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Enabled = false;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnlimpiar.Location = new System.Drawing.Point(805, 142);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(170, 39);
            this.btnlimpiar.TabIndex = 57;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.BackColor = System.Drawing.SystemColors.Window;
            this.txtCANTIDAD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCANTIDAD.FormattingEnabled = true;
            this.txtCANTIDAD.Location = new System.Drawing.Point(181, 148);
            this.txtCANTIDAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(116, 30);
            this.txtCANTIDAD.TabIndex = 58;
            // 
            // lblexist
            // 
            this.lblexist.AutoSize = true;
            this.lblexist.BackColor = System.Drawing.Color.Transparent;
            this.lblexist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblexist.Location = new System.Drawing.Point(161, 181);
            this.lblexist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblexist.Name = "lblexist";
            this.lblexist.Size = new System.Drawing.Size(0, 20);
            this.lblexist.TabIndex = 59;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1068, 702);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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