namespace FirmaAsimetricaWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtParaCifrar = new System.Windows.Forms.TextBox();
            this.btnCargarLlaveCifrado = new System.Windows.Forms.Button();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.btnCargarLlaveDescifrado = new System.Windows.Forms.Button();
            this.txtDescrifrado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerarLlaves = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnFirmar = new System.Windows.Forms.Button();
            this.btnValidarFirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto para cifrar";
            // 
            // txtParaCifrar
            // 
            this.txtParaCifrar.AcceptsReturn = true;
            this.txtParaCifrar.AcceptsTab = true;
            this.txtParaCifrar.Location = new System.Drawing.Point(12, 36);
            this.txtParaCifrar.Multiline = true;
            this.txtParaCifrar.Name = "txtParaCifrar";
            this.txtParaCifrar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtParaCifrar.Size = new System.Drawing.Size(776, 83);
            this.txtParaCifrar.TabIndex = 1;
            // 
            // btnCargarLlaveCifrado
            // 
            this.btnCargarLlaveCifrado.Location = new System.Drawing.Point(12, 125);
            this.btnCargarLlaveCifrado.Name = "btnCargarLlaveCifrado";
            this.btnCargarLlaveCifrado.Size = new System.Drawing.Size(141, 36);
            this.btnCargarLlaveCifrado.TabIndex = 2;
            this.btnCargarLlaveCifrado.Text = "Cargar Llave";
            this.btnCargarLlaveCifrado.UseVisualStyleBackColor = true;
            this.btnCargarLlaveCifrado.Click += new System.EventHandler(this.BtnCargarLlaveCifrado_Click);
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(159, 125);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(141, 36);
            this.btnCifrar.TabIndex = 3;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.BtnCifrar_Click);
            // 
            // txtCifrado
            // 
            this.txtCifrado.AcceptsReturn = true;
            this.txtCifrado.AcceptsTab = true;
            this.txtCifrado.Location = new System.Drawing.Point(12, 187);
            this.txtCifrado.Multiline = true;
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCifrado.Size = new System.Drawing.Size(776, 83);
            this.txtCifrado.TabIndex = 4;
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Location = new System.Drawing.Point(159, 276);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(141, 36);
            this.btnDescifrar.TabIndex = 6;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.BtnDescifrar_Click);
            // 
            // btnCargarLlaveDescifrado
            // 
            this.btnCargarLlaveDescifrado.Location = new System.Drawing.Point(12, 276);
            this.btnCargarLlaveDescifrado.Name = "btnCargarLlaveDescifrado";
            this.btnCargarLlaveDescifrado.Size = new System.Drawing.Size(141, 36);
            this.btnCargarLlaveDescifrado.TabIndex = 5;
            this.btnCargarLlaveDescifrado.Text = "Cargar Llave";
            this.btnCargarLlaveDescifrado.UseVisualStyleBackColor = true;
            this.btnCargarLlaveDescifrado.Click += new System.EventHandler(this.BtnCargarLlaveDescifrado_Click);
            // 
            // txtDescrifrado
            // 
            this.txtDescrifrado.AcceptsReturn = true;
            this.txtDescrifrado.AcceptsTab = true;
            this.txtDescrifrado.Location = new System.Drawing.Point(12, 338);
            this.txtDescrifrado.Multiline = true;
            this.txtDescrifrado.Name = "txtDescrifrado";
            this.txtDescrifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescrifrado.Size = new System.Drawing.Size(776, 83);
            this.txtDescrifrado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Texto cifrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Texto descrifrado";
            // 
            // btnGenerarLlaves
            // 
            this.btnGenerarLlaves.Location = new System.Drawing.Point(306, 125);
            this.btnGenerarLlaves.Name = "btnGenerarLlaves";
            this.btnGenerarLlaves.Size = new System.Drawing.Size(141, 36);
            this.btnGenerarLlaves.TabIndex = 10;
            this.btnGenerarLlaves.Text = "Generar Llaves";
            this.btnGenerarLlaves.UseVisualStyleBackColor = true;
            this.btnGenerarLlaves.Click += new System.EventHandler(this.BtnGenerarLlaves_Click);
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "xml";
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnFirmar
            // 
            this.btnFirmar.Location = new System.Drawing.Point(453, 125);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(141, 36);
            this.btnFirmar.TabIndex = 11;
            this.btnFirmar.Text = "Firmar";
            this.btnFirmar.UseVisualStyleBackColor = true;
            this.btnFirmar.Click += new System.EventHandler(this.BtnFirmar_Click);
            // 
            // btnValidarFirma
            // 
            this.btnValidarFirma.Location = new System.Drawing.Point(453, 276);
            this.btnValidarFirma.Name = "btnValidarFirma";
            this.btnValidarFirma.Size = new System.Drawing.Size(141, 36);
            this.btnValidarFirma.TabIndex = 12;
            this.btnValidarFirma.Text = "Validar Firma";
            this.btnValidarFirma.UseVisualStyleBackColor = true;
            this.btnValidarFirma.Click += new System.EventHandler(this.BtnValidarFirma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.btnValidarFirma);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.btnGenerarLlaves);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescrifrado);
            this.Controls.Add(this.btnDescifrar);
            this.Controls.Add(this.btnCargarLlaveDescifrado);
            this.Controls.Add(this.txtCifrado);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.btnCargarLlaveCifrado);
            this.Controls.Add(this.txtParaCifrar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParaCifrar;
        private System.Windows.Forms.Button btnCargarLlaveCifrado;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.Button btnCargarLlaveDescifrado;
        private System.Windows.Forms.TextBox txtDescrifrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerarLlaves;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.Button btnValidarFirma;
    }
}

