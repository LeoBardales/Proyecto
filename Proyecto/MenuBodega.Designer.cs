
namespace Proyecto
{
    partial class MenuBodega
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
            this.btnClienteMes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienteMes
            // 
            this.btnClienteMes.Location = new System.Drawing.Point(27, 23);
            this.btnClienteMes.Name = "btnClienteMes";
            this.btnClienteMes.Size = new System.Drawing.Size(140, 57);
            this.btnClienteMes.TabIndex = 18;
            this.btnClienteMes.Text = "INGRESO";
            this.btnClienteMes.UseVisualStyleBackColor = true;
            this.btnClienteMes.Click += new System.EventHandler(this.btnClienteMes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "REGISTRO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClienteMes);
            this.Name = "MenuBodega";
            this.Text = "MenuBodega";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClienteMes;
        private System.Windows.Forms.Button button1;
    }
}