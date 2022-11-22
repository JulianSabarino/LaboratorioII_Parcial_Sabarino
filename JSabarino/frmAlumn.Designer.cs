namespace JSabarino
{
    partial class frmAlumn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumn));
            this.lstMateriasInscriptas = new System.Windows.Forms.ListBox();
            this.lstEventosMateria = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDarPresente = new System.Windows.Forms.Button();
            this.btnAnotarse = new System.Windows.Forms.Button();
            this.lstMateriasParaAnotarse = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMateriasInscriptas
            // 
            this.lstMateriasInscriptas.FormattingEnabled = true;
            this.lstMateriasInscriptas.ItemHeight = 15;
            this.lstMateriasInscriptas.Location = new System.Drawing.Point(6, 22);
            this.lstMateriasInscriptas.Name = "lstMateriasInscriptas";
            this.lstMateriasInscriptas.Size = new System.Drawing.Size(120, 94);
            this.lstMateriasInscriptas.TabIndex = 0;
            this.lstMateriasInscriptas.SelectedIndexChanged += new System.EventHandler(this.lstMateriasInscriptas_SelectedIndexChanged);
            // 
            // lstEventosMateria
            // 
            this.lstEventosMateria.FormattingEnabled = true;
            this.lstEventosMateria.ItemHeight = 15;
            this.lstEventosMateria.Location = new System.Drawing.Point(132, 22);
            this.lstEventosMateria.Name = "lstEventosMateria";
            this.lstEventosMateria.Size = new System.Drawing.Size(120, 109);
            this.lstEventosMateria.TabIndex = 1;
            this.lstEventosMateria.SelectedIndexChanged += new System.EventHandler(this.lstEventosMateria_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDarPresente);
            this.groupBox1.Controls.Add(this.lstEventosMateria);
            this.groupBox1.Controls.Add(this.lstMateriasInscriptas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dar Presente";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(51, 116);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(0, 15);
            this.lblNota.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nota: ";
            // 
            // btnDarPresente
            // 
            this.btnDarPresente.Location = new System.Drawing.Point(6, 137);
            this.btnDarPresente.Name = "btnDarPresente";
            this.btnDarPresente.Size = new System.Drawing.Size(246, 23);
            this.btnDarPresente.TabIndex = 2;
            this.btnDarPresente.Text = "Dar Presente";
            this.btnDarPresente.UseVisualStyleBackColor = true;
            this.btnDarPresente.Click += new System.EventHandler(this.btnDarPresente_Click);
            // 
            // btnAnotarse
            // 
            this.btnAnotarse.Location = new System.Drawing.Point(132, 22);
            this.btnAnotarse.Name = "btnAnotarse";
            this.btnAnotarse.Size = new System.Drawing.Size(114, 23);
            this.btnAnotarse.TabIndex = 3;
            this.btnAnotarse.Text = "Anotarse";
            this.btnAnotarse.UseVisualStyleBackColor = true;
            this.btnAnotarse.Click += new System.EventHandler(this.btnAnotarse_Click);
            // 
            // lstMateriasParaAnotarse
            // 
            this.lstMateriasParaAnotarse.FormattingEnabled = true;
            this.lstMateriasParaAnotarse.ItemHeight = 15;
            this.lstMateriasParaAnotarse.Location = new System.Drawing.Point(6, 22);
            this.lstMateriasParaAnotarse.Name = "lstMateriasParaAnotarse";
            this.lstMateriasParaAnotarse.Size = new System.Drawing.Size(120, 94);
            this.lstMateriasParaAnotarse.TabIndex = 4;
            this.lstMateriasParaAnotarse.SelectedIndexChanged += new System.EventHandler(this.lstMateriasParaAnotarse_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMateriasParaAnotarse);
            this.groupBox2.Controls.Add(this.btnAnotarse);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anotarse a Materia";
            // 
            // frmAlumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 365);
            this.MinimumSize = new System.Drawing.Size(300, 365);
            this.Name = "frmAlumn";
            this.Text = "Cuenta: Alumno";
            this.Load += new System.EventHandler(this.frmAlumn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstMateriasInscriptas;
        private ListBox lstEventosMateria;
        private GroupBox groupBox1;
        private Button btnDarPresente;
        private Button btnAnotarse;
        private ListBox lstMateriasParaAnotarse;
        private GroupBox groupBox2;
        private Label lblNota;
        private Label label1;
    }
}