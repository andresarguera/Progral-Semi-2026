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
            this.lblDe = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.cboDe = new System.Windows.Forms.ComboBox();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(148, 228);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(55, 33);
            this.lblDe.TabIndex = 0;
            this.lblDe.Text = "De:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(278, 368);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(204, 40);
            this.txtCantidad.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(267, 490);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(249, 80);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(516, 368);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(155, 33);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta: ?";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(463, 228);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(42, 33);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "A:";
            // 
            // cboDe
            // 
            this.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDe.FormattingEnabled = true;
            this.cboDe.Items.AddRange(new object[] {
            "Metros",
            "Cm",
            "Pulgadas",
            "Pies",
            "Varas",
            "Yardas",
            "Km",
            "Millas"});
            this.cboDe.Location = new System.Drawing.Point(209, 233);
            this.cboDe.Name = "cboDe";
            this.cboDe.Size = new System.Drawing.Size(162, 28);
            this.cboDe.TabIndex = 7;
            // 
            // cboA
            // 
            this.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboA.FormattingEnabled = true;
            this.cboA.Items.AddRange(new object[] {
            "Metros",
            "Cm",
            "Pulgadas",
            "Pies",
            "Varas",
            "Yardas",
            "Km",
            "Millas"});
            this.cboA.Location = new System.Drawing.Point(511, 233);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(160, 28);
            this.cboA.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(148, 371);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(124, 33);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(148, 95);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(128, 33);
            this.lblOpciones.TabIndex = 10;
            this.lblOpciones.Text = "Opciones:";
            // 
            // cboOpciones
            // 
            this.cboOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Longitud",
            "Moneda",
            "Masa",
            "Volumen",
            "Almacenamiento",
            "Tiempo"});
            this.cboOpciones.Location = new System.Drawing.Point(282, 102);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(162, 28);
            this.cboOpciones.TabIndex = 11;
            this.cboOpciones.SelectedIndexChanged += new System.EventHandler(this.cboOpciones_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 609);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboA);
            this.Controls.Add(this.cboDe);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblDe);
            this.Name = "Form1";
            this.Text = "Conversores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cboDe;
        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.ComboBox cboOpciones;
    }
}

