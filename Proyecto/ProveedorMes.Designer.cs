
namespace Proyecto
{
    partial class ProveedorMes
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
            this.cmdano = new System.Windows.Forms.ComboBox();
            this.cmbmes = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdano
            // 
            this.cmdano.FormattingEnabled = true;
            this.cmdano.Location = new System.Drawing.Point(258, 37);
            this.cmdano.Name = "cmdano";
            this.cmdano.Size = new System.Drawing.Size(153, 24);
            this.cmdano.TabIndex = 5;
            this.cmdano.SelectedIndexChanged += new System.EventHandler(this.cmdano_SelectedIndexChanged);
            // 
            // cmbmes
            // 
            this.cmbmes.FormattingEnabled = true;
            this.cmbmes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo ",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbmes.Location = new System.Drawing.Point(40, 37);
            this.cmbmes.Name = "cmbmes";
            this.cmbmes.Size = new System.Drawing.Size(150, 24);
            this.cmbmes.TabIndex = 4;
            this.cmbmes.SelectedIndexChanged += new System.EventHandler(this.cmbmes_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 252);
            this.dataGridView1.TabIndex = 3;
            // 
            // ProveedorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.cmdano);
            this.Controls.Add(this.cmbmes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProveedorMes";
            this.Text = "ProveedorMes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdano;
        private System.Windows.Forms.ComboBox cmbmes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}