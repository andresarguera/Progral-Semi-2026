namespace miPrimeaAplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.ltsValores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(138, 76);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(250, 26);
            this.txtSerie.TabIndex = 13;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(38, 69);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(80, 33);
            this.lblSerie.TabIndex = 10;
            this.lblSerie.Text = "Serie:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(502, 302);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(313, 196);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // ltsValores
            // 
            this.ltsValores.FormattingEnabled = true;
            this.ltsValores.ItemHeight = 20;
            this.ltsValores.Location = new System.Drawing.Point(44, 191);
            this.ltsValores.Name = "ltsValores";
            this.ltsValores.Size = new System.Drawing.Size(397, 324);
            this.ltsValores.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 609);
            this.Controls.Add(this.ltsValores);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Media Aritmetica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ListBox ltsValores;
    }
}

