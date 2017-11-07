namespace ClaseVeinte.WForms
{
    partial class frmPrincipal
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
            this.lsboxPersonas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnELiminar = new System.Windows.Forms.Button();
            this.dgwPersonas = new System.Windows.Forms.DataGridView();
            this.btnBackUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lsboxPersonas
            // 
            this.lsboxPersonas.FormattingEnabled = true;
            this.lsboxPersonas.Location = new System.Drawing.Point(-2, 56);
            this.lsboxPersonas.Name = "lsboxPersonas";
            this.lsboxPersonas.Size = new System.Drawing.Size(536, 4);
            this.lsboxPersonas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(12, 238);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Yellow;
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(204, 238);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnELiminar
            // 
            this.btnELiminar.BackColor = System.Drawing.Color.Red;
            this.btnELiminar.ForeColor = System.Drawing.Color.Black;
            this.btnELiminar.Location = new System.Drawing.Point(398, 238);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(108, 23);
            this.btnELiminar.TabIndex = 3;
            this.btnELiminar.Text = "ELIMINAR";
            this.btnELiminar.UseVisualStyleBackColor = false;
            this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
            // 
            // dgwPersonas
            // 
            this.dgwPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonas.Location = new System.Drawing.Point(-2, 64);
            this.dgwPersonas.Name = "dgwPersonas";
            this.dgwPersonas.Size = new System.Drawing.Size(536, 150);
            this.dgwPersonas.TabIndex = 4;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(204, 27);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(75, 23);
            this.btnBackUp.TabIndex = 5;
            this.btnBackUp.Text = "BACKUP";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 273);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.dgwPersonas);
            this.Controls.Add(this.btnELiminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lsboxPersonas);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsboxPersonas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnELiminar;
        private System.Windows.Forms.DataGridView dgwPersonas;
        private System.Windows.Forms.Button btnBackUp;
    }
}

