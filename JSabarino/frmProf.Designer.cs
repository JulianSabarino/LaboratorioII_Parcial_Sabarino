namespace JSabarino
{
    partial class frmProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProf));
            this.lstbMateriasPerProf = new System.Windows.Forms.ListBox();
            this.calendarEvento = new System.Windows.Forms.MonthCalendar();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.chkParcial = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnPonerNota = new System.Windows.Forms.Button();
            this.numericNota = new System.Windows.Forms.NumericUpDown();
            this.lstbAlumnosPresentes = new System.Windows.Forms.ListBox();
            this.lstbParcial = new System.Windows.Forms.ListBox();
            this.btnCerrarParcial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNota)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbMateriasPerProf
            // 
            this.lstbMateriasPerProf.FormattingEnabled = true;
            this.lstbMateriasPerProf.ItemHeight = 15;
            this.lstbMateriasPerProf.Location = new System.Drawing.Point(6, 22);
            this.lstbMateriasPerProf.Name = "lstbMateriasPerProf";
            this.lstbMateriasPerProf.Size = new System.Drawing.Size(120, 169);
            this.lstbMateriasPerProf.TabIndex = 0;
            this.lstbMateriasPerProf.SelectedIndexChanged += new System.EventHandler(this.lstbMateriasPerProf_SelectedIndexChanged);
            // 
            // calendarEvento
            // 
            this.calendarEvento.Location = new System.Drawing.Point(144, 22);
            this.calendarEvento.MaxSelectionCount = 1;
            this.calendarEvento.Name = "calendarEvento";
            this.calendarEvento.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(81, 199);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(177, 23);
            this.txtDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion";
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(290, 226);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(75, 23);
            this.btnCrearEvento.TabIndex = 4;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // chkParcial
            // 
            this.chkParcial.AutoSize = true;
            this.chkParcial.Location = new System.Drawing.Point(290, 201);
            this.chkParcial.Name = "chkParcial";
            this.chkParcial.Size = new System.Drawing.Size(75, 19);
            this.chkParcial.TabIndex = 5;
            this.chkParcial.Text = "Es Parcial";
            this.chkParcial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbMateriasPerProf);
            this.groupBox1.Controls.Add(this.chkParcial);
            this.groupBox1.Controls.Add(this.calendarEvento);
            this.groupBox1.Controls.Add(this.btnCrearEvento);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 262);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Evento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCerrarParcial);
            this.groupBox2.Controls.Add(this.btnFinalizar);
            this.groupBox2.Controls.Add(this.btnPonerNota);
            this.groupBox2.Controls.Add(this.numericNota);
            this.groupBox2.Controls.Add(this.lstbAlumnosPresentes);
            this.groupBox2.Controls.Add(this.lstbParcial);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 202);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poner Nota";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(258, 168);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(107, 23);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar Cursada";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnPonerNota
            // 
            this.btnPonerNota.Location = new System.Drawing.Point(258, 51);
            this.btnPonerNota.Name = "btnPonerNota";
            this.btnPonerNota.Size = new System.Drawing.Size(107, 23);
            this.btnPonerNota.TabIndex = 3;
            this.btnPonerNota.Text = "Poner Nota";
            this.btnPonerNota.UseVisualStyleBackColor = true;
            this.btnPonerNota.Click += new System.EventHandler(this.btnPonerNota_Click);
            // 
            // numericNota
            // 
            this.numericNota.Location = new System.Drawing.Point(258, 22);
            this.numericNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNota.Name = "numericNota";
            this.numericNota.Size = new System.Drawing.Size(107, 23);
            this.numericNota.TabIndex = 2;
            this.numericNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstbAlumnosPresentes
            // 
            this.lstbAlumnosPresentes.FormattingEnabled = true;
            this.lstbAlumnosPresentes.ItemHeight = 15;
            this.lstbAlumnosPresentes.Location = new System.Drawing.Point(132, 22);
            this.lstbAlumnosPresentes.Name = "lstbAlumnosPresentes";
            this.lstbAlumnosPresentes.Size = new System.Drawing.Size(120, 169);
            this.lstbAlumnosPresentes.TabIndex = 1;
            this.lstbAlumnosPresentes.SelectedIndexChanged += new System.EventHandler(this.lstbAlumnosPresentes_SelectedIndexChanged);
            // 
            // lstbParcial
            // 
            this.lstbParcial.FormattingEnabled = true;
            this.lstbParcial.ItemHeight = 15;
            this.lstbParcial.Location = new System.Drawing.Point(6, 22);
            this.lstbParcial.Name = "lstbParcial";
            this.lstbParcial.Size = new System.Drawing.Size(120, 169);
            this.lstbParcial.TabIndex = 0;
            this.lstbParcial.SelectedIndexChanged += new System.EventHandler(this.lstbParcial_SelectedIndexChanged);
            // 
            // btnCerrarParcial
            // 
            this.btnCerrarParcial.Location = new System.Drawing.Point(258, 80);
            this.btnCerrarParcial.Name = "btnCerrarParcial";
            this.btnCerrarParcial.Size = new System.Drawing.Size(107, 23);
            this.btnCerrarParcial.TabIndex = 5;
            this.btnCerrarParcial.Text = "Cerrar Parcial";
            this.btnCerrarParcial.UseVisualStyleBackColor = true;
            this.btnCerrarParcial.Click += new System.EventHandler(this.btnCerrarParcial_Click);
            // 
            // frmProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(425, 555);
            this.MinimumSize = new System.Drawing.Size(425, 555);
            this.Name = "frmProf";
            this.Text = "Cuenta: Profesor";
            this.Load += new System.EventHandler(this.frmProf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstbMateriasPerProf;
        private MonthCalendar calendarEvento;
        private TextBox txtDesc;
        private Label label1;
        private Button btnCrearEvento;
        private CheckBox chkParcial;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnPonerNota;
        private NumericUpDown numericNota;
        private ListBox lstbAlumnosPresentes;
        private ListBox lstbParcial;
        private Button btnFinalizar;
        private Button btnCerrarParcial;
    }
}