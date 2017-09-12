namespace TestPaletaWindowsForm
{
    partial class FrmPaleta
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
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(12, 31);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(75, 23);
            this.btnMas.TabIndex = 0;
            this.btnMas.Text = "BTN+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click_1);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(244, 31);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 23);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "BTN-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 117);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(355, 95);
            this.listBox2.TabIndex = 2;
            // 
            // FrmPaleta
            // 
            this.ClientSize = new System.Drawing.Size(367, 277);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Name = "FrmPaleta";
            this.Load += new System.EventHandler(this.FrmPaleta_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.ListBox listBox2;
    }
}

