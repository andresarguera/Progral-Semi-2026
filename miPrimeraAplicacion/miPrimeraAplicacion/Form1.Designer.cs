namespace miPrimeraAplicacion
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblActividadEconomica = new System.Windows.Forms.Label();
            this.txtEconomia = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(355, 305);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(313, 81);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblActividadEconomica
            // 
            this.lblActividadEconomica.AutoSize = true;
            this.lblActividadEconomica.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividadEconomica.Location = new System.Drawing.Point(58, 92);
            this.lblActividadEconomica.Name = "lblActividadEconomica";
            this.lblActividadEconomica.Size = new System.Drawing.Size(271, 32);
            this.lblActividadEconomica.TabIndex = 35;
            this.lblActividadEconomica.Text = "Actividad economica:";
            // 
            // txtEconomia
            // 
            this.txtEconomia.Location = new System.Drawing.Point(335, 99);
            this.txtEconomia.Name = "txtEconomia";
            this.txtEconomia.Size = new System.Drawing.Size(381, 26);
            this.txtEconomia.TabIndex = 36;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(388, 217);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(244, 32);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "Total de impuestos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1183, 494);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtEconomia);
            this.Controls.Add(this.lblActividadEconomica);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Calculador de Impuestos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblActividadEconomica;
        private System.Windows.Forms.TextBox txtEconomia;
        private System.Windows.Forms.Label lblTotal;
    }
    

    }

