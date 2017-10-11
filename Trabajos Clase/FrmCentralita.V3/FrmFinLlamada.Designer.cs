namespace FrmCentralita.V3
{
    partial class FrmFinLlamada
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
            this.lblCostoFinal = new System.Windows.Forms.Label();
            this.txtBoxCostoFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCostoFinal
            // 
            this.lblCostoFinal.AutoSize = true;
            this.lblCostoFinal.Location = new System.Drawing.Point(12, 159);
            this.lblCostoFinal.Name = "lblCostoFinal";
            this.lblCostoFinal.Size = new System.Drawing.Size(59, 13);
            this.lblCostoFinal.TabIndex = 8;
            this.lblCostoFinal.Text = "Costo Final";
            // 
            // txtBoxCostoFinal
            // 
            this.txtBoxCostoFinal.Location = new System.Drawing.Point(15, 175);
            this.txtBoxCostoFinal.Name = "txtBoxCostoFinal";
            this.txtBoxCostoFinal.Size = new System.Drawing.Size(96, 20);
            this.txtBoxCostoFinal.TabIndex = 9;
            // 
            // FrmFinLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 262);
            this.Controls.Add(this.txtBoxCostoFinal);
            this.Controls.Add(this.lblCostoFinal);
            this.Name = "FrmFinLlamada";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.txtDuracion, 0);
            this.Controls.SetChildIndex(this.lblCostoFinal, 0);
            this.Controls.SetChildIndex(this.txtBoxCostoFinal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCostoFinal;
        private System.Windows.Forms.TextBox txtBoxCostoFinal;
    }
}