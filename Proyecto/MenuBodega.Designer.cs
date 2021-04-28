
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienteMes
            // 
            this.btnClienteMes.Location = new System.Drawing.Point(20, 19);
            this.btnClienteMes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClienteMes.Name = "btnClienteMes";
            this.btnClienteMes.Size = new System.Drawing.Size(105, 46);
            this.btnClienteMes.TabIndex = 18;
            this.btnClienteMes.Text = "INGRESO";
            this.btnClienteMes.UseVisualStyleBackColor = true;
            this.btnClienteMes.Click += new System.EventHandler(this.btnClienteMes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "REGISTRO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 46);
            this.button2.TabIndex = 20;
            this.button2.Text = "ELABORACIÓN DE PRODUCTOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MenuBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 184);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClienteMes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuBodega";
            this.Text = "MenuBodega";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClienteMes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}