
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
            this.txtFACTURA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDESCUENTO = new System.Windows.Forms.TextBox();
            this.btnACTUALIZAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.cmbARTICULO = new System.Windows.Forms.ComboBox();
            this.btnINGRESARPRODUCTOS = new System.Windows.Forms.Button();
            this.btnACTUALIZARVENTA = new System.Windows.Forms.Button();
            this.btnACTUALIZARDETALLEVENTA = new System.Windows.Forms.Button();
            this.btnVENTAELIMINAR = new System.Windows.Forms.Button();
            this.btnELIMINARDETALLEVENTA = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            // 
            // cmbTIPOVENTA
            // 
            this.cmbTIPOVENTA.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTIPOVENTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTIPOVENTA.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTIPOVENTA.FormattingEnabled = true;
            this.cmbTIPOVENTA.Items.AddRange(new object[] {
            "AL POR MAYOR",
            "AL DETALLE"});
            this.cmbTIPOVENTA.Location = new System.Drawing.Point(136, 40);
            this.cmbTIPOVENTA.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTIPOVENTA.Name = "cmbTIPOVENTA";
            this.cmbTIPOVENTA.Size = new System.Drawing.Size(152, 25);
            this.cmbTIPOVENTA.TabIndex = 15;
            // 
            // cmbPAGO
            // 
            this.cmbPAGO.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnVENTA
            // 
            this.btnVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVENTA.Location = new System.Drawing.Point(552, 8);
            this.btnVENTA.Name = "btnVENTA";
            this.btnVENTA.Size = new System.Drawing.Size(120, 48);
            this.btnVENTA.TabIndex = 19;
            this.btnVENTA.Text = "NUEVA VENTA";
            this.btnVENTA.UseVisualStyleBackColor = true;
            this.btnVENTA.Click += new System.EventHandler(this.BtnVENTA_Click);
            // 
            // txtFACTURA
            // 
            this.txtFACTURA.Enabled = false;
            this.txtFACTURA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFACTURA.Location = new System.Drawing.Point(16, 120);
            this.txtFACTURA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFACTURA.Multiline = true;
            this.txtFACTURA.Name = "txtFACTURA";
            this.txtFACTURA.Size = new System.Drawing.Size(96, 24);
            this.txtFACTURA.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "FACTURA ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(128, 96);
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
            this.label4.Location = new System.Drawing.Point(248, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "CANTIDAD";
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Enabled = false;
            this.txtCANTIDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCANTIDAD.Location = new System.Drawing.Point(248, 120);
            this.txtCANTIDAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCANTIDAD.Multiline = true;
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(83, 24);
            this.txtCANTIDAD.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(344, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "DESCUENTO";
            // 
            // txtDESCUENTO
            // 
            this.txtDESCUENTO.Enabled = false;
            this.txtDESCUENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDESCUENTO.Location = new System.Drawing.Point(344, 120);
            this.txtDESCUENTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDESCUENTO.Multiline = true;
            this.txtDESCUENTO.Name = "txtDESCUENTO";
            this.txtDESCUENTO.Size = new System.Drawing.Size(104, 24);
            this.txtDESCUENTO.TabIndex = 42;
            // 
            // btnACTUALIZAR
            // 
            this.btnACTUALIZAR.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnACTUALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnACTUALIZAR.Location = new System.Drawing.Point(752, 64);
            this.btnACTUALIZAR.Name = "btnACTUALIZAR";
            this.btnACTUALIZAR.Size = new System.Drawing.Size(115, 32);
            this.btnACTUALIZAR.TabIndex = 44;
            this.btnACTUALIZAR.Text = "ACTUALIZAR";
            this.btnACTUALIZAR.UseVisualStyleBackColor = false;
            this.btnACTUALIZAR.Click += new System.EventHandler(this.BtnACTUALIZAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCANCELAR.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCANCELAR.Location = new System.Drawing.Point(800, 8);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(112, 48);
            this.btnCANCELAR.TabIndex = 45;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.BtnCANCELAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnELIMINAR.Location = new System.Drawing.Point(632, 64);
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
            this.cmbARTICULO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbARTICULO.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbARTICULO.FormattingEnabled = true;
            this.cmbARTICULO.Location = new System.Drawing.Point(128, 120);
            this.cmbARTICULO.Margin = new System.Windows.Forms.Padding(2);
            this.cmbARTICULO.Name = "cmbARTICULO";
            this.cmbARTICULO.Size = new System.Drawing.Size(96, 25);
            this.cmbARTICULO.TabIndex = 47;
            // 
            // btnINGRESARPRODUCTOS
            // 
            this.btnINGRESARPRODUCTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnINGRESARPRODUCTOS.Location = new System.Drawing.Point(680, 8);
            this.btnINGRESARPRODUCTOS.Name = "btnINGRESARPRODUCTOS";
            this.btnINGRESARPRODUCTOS.Size = new System.Drawing.Size(112, 48);
            this.btnINGRESARPRODUCTOS.TabIndex = 48;
            this.btnINGRESARPRODUCTOS.Text = "INGRESAR PRODUCTOS";
            this.btnINGRESARPRODUCTOS.UseVisualStyleBackColor = true;
            this.btnINGRESARPRODUCTOS.Click += new System.EventHandler(this.BtnINGRESARPRODUCTOS_Click);
            // 
            // btnACTUALIZARVENTA
            // 
            this.btnACTUALIZARVENTA.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnACTUALIZARVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnACTUALIZARVENTA.Location = new System.Drawing.Point(752, 104);
            this.btnACTUALIZARVENTA.Name = "btnACTUALIZARVENTA";
            this.btnACTUALIZARVENTA.Size = new System.Drawing.Size(115, 32);
            this.btnACTUALIZARVENTA.TabIndex = 49;
            this.btnACTUALIZARVENTA.Text = "VENTA";
            this.btnACTUALIZARVENTA.UseVisualStyleBackColor = false;
            this.btnACTUALIZARVENTA.Click += new System.EventHandler(this.BtnACTUALIZARVENTA_Click);
            // 
            // btnACTUALIZARDETALLEVENTA
            // 
            this.btnACTUALIZARDETALLEVENTA.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnACTUALIZARDETALLEVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnACTUALIZARDETALLEVENTA.Location = new System.Drawing.Point(752, 144);
            this.btnACTUALIZARDETALLEVENTA.Name = "btnACTUALIZARDETALLEVENTA";
            this.btnACTUALIZARDETALLEVENTA.Size = new System.Drawing.Size(115, 40);
            this.btnACTUALIZARDETALLEVENTA.TabIndex = 50;
            this.btnACTUALIZARDETALLEVENTA.Text = "DETALLE VENTA";
            this.btnACTUALIZARDETALLEVENTA.UseVisualStyleBackColor = false;
            this.btnACTUALIZARDETALLEVENTA.Click += new System.EventHandler(this.BtnACTUALIZARDETALLEVENTA_Click);
            // 
            // btnVENTAELIMINAR
            // 
            this.btnVENTAELIMINAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVENTAELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVENTAELIMINAR.Location = new System.Drawing.Point(632, 104);
            this.btnVENTAELIMINAR.Name = "btnVENTAELIMINAR";
            this.btnVENTAELIMINAR.Size = new System.Drawing.Size(107, 32);
            this.btnVENTAELIMINAR.TabIndex = 51;
            this.btnVENTAELIMINAR.Text = "VENTA";
            this.btnVENTAELIMINAR.UseVisualStyleBackColor = false;
            this.btnVENTAELIMINAR.Click += new System.EventHandler(this.BtnVENTAELIMINAR_Click);
            // 
            // btnELIMINARDETALLEVENTA
            // 
            this.btnELIMINARDETALLEVENTA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnELIMINARDETALLEVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnELIMINARDETALLEVENTA.Location = new System.Drawing.Point(632, 144);
            this.btnELIMINARDETALLEVENTA.Name = "btnELIMINARDETALLEVENTA";
            this.btnELIMINARDETALLEVENTA.Size = new System.Drawing.Size(107, 40);
            this.btnELIMINARDETALLEVENTA.TabIndex = 52;
            this.btnELIMINARDETALLEVENTA.Text = "DETALLE VENTA";
            this.btnELIMINARDETALLEVENTA.UseVisualStyleBackColor = false;
            this.btnELIMINARDETALLEVENTA.Click += new System.EventHandler(this.BtnELIMINARDETALLEVENTA_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
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
            this.dataGridView1.Location = new System.Drawing.Point(8, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(424, 205);
            this.dataGridView1.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(168, 216);
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
            this.label7.Location = new System.Drawing.Point(624, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "DETALLE VENTA";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
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
            this.dataGridView2.Location = new System.Drawing.Point(440, 240);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(480, 205);
            this.dataGridView2.TabIndex = 55;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(932, 452);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnELIMINARDETALLEVENTA);
            this.Controls.Add(this.btnVENTAELIMINAR);
            this.Controls.Add(this.btnACTUALIZARDETALLEVENTA);
            this.Controls.Add(this.btnACTUALIZARVENTA);
            this.Controls.Add(this.btnINGRESARPRODUCTOS);
            this.Controls.Add(this.cmbARTICULO);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnACTUALIZAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDESCUENTO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCANTIDAD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFACTURA);
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
        private System.Windows.Forms.TextBox txtFACTURA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDESCUENTO;
        private System.Windows.Forms.Button btnACTUALIZAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.ComboBox cmbARTICULO;
        private System.Windows.Forms.Button btnINGRESARPRODUCTOS;
        private System.Windows.Forms.Button btnACTUALIZARVENTA;
        private System.Windows.Forms.Button btnACTUALIZARDETALLEVENTA;
        private System.Windows.Forms.Button btnVENTAELIMINAR;
        private System.Windows.Forms.Button btnELIMINARDETALLEVENTA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}