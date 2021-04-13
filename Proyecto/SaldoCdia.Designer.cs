
namespace Proyecto
{
    partial class SaldoCdia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbmes = new System.Windows.Forms.ComboBox();
            this.cmdano = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 252);
            this.dataGridView1.TabIndex = 0;
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
            this.cmbmes.Location = new System.Drawing.Point(65, 54);
            this.cmbmes.Name = "cmbmes";
            this.cmbmes.Size = new System.Drawing.Size(150, 24);
            this.cmbmes.TabIndex = 1;
            this.cmbmes.SelectedIndexChanged += new System.EventHandler(this.cmbmes_SelectedIndexChanged);
            // 
            // cmdano
            // 
            this.cmdano.FormattingEnabled = true;
            this.cmdano.Location = new System.Drawing.Point(244, 54);
            this.cmdano.Name = "cmdano";
            this.cmdano.Size = new System.Drawing.Size(153, 24);
            this.cmdano.TabIndex = 2;
            this.cmdano.SelectedIndexChanged += new System.EventHandler(this.cmdano_SelectedIndexChanged);
            // 
            // SaldoCdia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.cmdano);
            this.Controls.Add(this.cmbmes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SaldoCdia";
            this.Text = "SaldoCdia";
            this.Load += new System.EventHandler(this.SaldoCdia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbmes;
        private System.Windows.Forms.ComboBox cmdano;
    }
}