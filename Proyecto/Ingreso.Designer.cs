
namespace Proyecto
{
    partial class Ingreso
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbarticulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnINGRESARPRODUCTOS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConstancia = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtConstancia = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(31, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "COMPRAID";
            // 
            // txtcompra
            // 
            this.txtcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompra.Location = new System.Drawing.Point(13, 40);
            this.txtcompra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtcompra.Multiline = true;
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(137, 29);
            this.txtcompra.TabIndex = 44;
            this.txtcompra.Leave += new System.EventHandler(this.txtcompra_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "ARTICULOID";
            // 
            // cmbarticulo
            // 
            this.cmbarticulo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbarticulo.Enabled = false;
            this.cmbarticulo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbarticulo.FormattingEnabled = true;
            this.cmbarticulo.Items.AddRange(new object[] {
            "AL POR MAYOR",
            "DETALLE"});
            this.cmbarticulo.Location = new System.Drawing.Point(181, 40);
            this.cmbarticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbarticulo.Name = "cmbarticulo";
            this.cmbarticulo.Size = new System.Drawing.Size(167, 30);
            this.cmbarticulo.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(404, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(386, 42);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(137, 29);
            this.txtCantidad.TabIndex = 48;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(13, 120);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 50;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnINGRESARPRODUCTOS
            // 
            this.btnINGRESARPRODUCTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnINGRESARPRODUCTOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnINGRESARPRODUCTOS.Location = new System.Drawing.Point(371, 120);
            this.btnINGRESARPRODUCTOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnINGRESARPRODUCTOS.Name = "btnINGRESARPRODUCTOS";
            this.btnINGRESARPRODUCTOS.Size = new System.Drawing.Size(171, 39);
            this.btnINGRESARPRODUCTOS.TabIndex = 51;
            this.btnINGRESARPRODUCTOS.Text = "INGRESAR";
            this.btnINGRESARPRODUCTOS.UseVisualStyleBackColor = true;
            this.btnINGRESARPRODUCTOS.Click += new System.EventHandler(this.btnINGRESARPRODUCTOS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "FECHA DE VENCIMIENTO";
            // 
            // btnConstancia
            // 
            this.btnConstancia.Enabled = false;
            this.btnConstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConstancia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConstancia.Location = new System.Drawing.Point(371, 176);
            this.btnConstancia.Margin = new System.Windows.Forms.Padding(4);
            this.btnConstancia.Name = "btnConstancia";
            this.btnConstancia.Size = new System.Drawing.Size(171, 39);
            this.btnConstancia.TabIndex = 53;
            this.btnConstancia.Text = "CONSTANCIA";
            this.btnConstancia.UseVisualStyleBackColor = true;
            this.btnConstancia.Click += new System.EventHandler(this.btnConstancia_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(371, 232);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 39);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtConstancia
            // 
            this.txtConstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConstancia.Location = new System.Drawing.Point(13, 338);
            this.txtConstancia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtConstancia.Multiline = true;
            this.txtConstancia.Name = "txtConstancia";
            this.txtConstancia.Size = new System.Drawing.Size(398, 88);
            this.txtConstancia.TabIndex = 55;
            this.txtConstancia.Visible = false;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguardar.Location = new System.Drawing.Point(419, 359);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(171, 39);
            this.btnguardar.TabIndex = 56;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(596, 437);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtConstancia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConstancia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnINGRESARPRODUCTOS);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbarticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcompra);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbarticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnINGRESARPRODUCTOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConstancia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtConstancia;
        private System.Windows.Forms.Button btnguardar;
    }
}