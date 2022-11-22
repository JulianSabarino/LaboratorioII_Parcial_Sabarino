namespace JSabarino
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tcontrolAdmin = new System.Windows.Forms.TabControl();
            this.tpageUsers = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCrearUser = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lstbUsers = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboxUserType = new System.Windows.Forms.ComboBox();
            this.tSubject = new System.Windows.Forms.TabPage();
            this.rtxtDescMateria = new System.Windows.Forms.RichTextBox();
            this.lstbMaterias = new System.Windows.Forms.ListBox();
            this.tpageModSubject = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescSubj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chklbMaterias = new System.Windows.Forms.CheckedListBox();
            this.btnCrearMateria = new System.Windows.Forms.Button();
            this.cbCuatri = new System.Windows.Forms.ComboBox();
            this.lstbProf = new System.Windows.Forms.ListBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tpageModifyProf = new System.Windows.Forms.TabPage();
            this.btnChangeProfessor = new System.Windows.Forms.Button();
            this.lstChangeProfesor = new System.Windows.Forms.ListBox();
            this.lstChangeSubject = new System.Windows.Forms.ListBox();
            this.tpageRegAlumn = new System.Windows.Forms.TabPage();
            this.cmbRegular = new System.Windows.Forms.ComboBox();
            this.lblSubjectStatus = new System.Windows.Forms.Label();
            this.btnRegularizarAlumn = new System.Windows.Forms.Button();
            this.lstSubjectAlumns = new System.Windows.Forms.ListBox();
            this.lstSubjectsToAlumns = new System.Windows.Forms.ListBox();
            this.tpageInscribirAlumno = new System.Windows.Forms.TabPage();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.lstMateriasAlumnos = new System.Windows.Forms.ListBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.tcontrolAdmin.SuspendLayout();
            this.tpageUsers.SuspendLayout();
            this.tSubject.SuspendLayout();
            this.tpageModSubject.SuspendLayout();
            this.tpageModifyProf.SuspendLayout();
            this.tpageRegAlumn.SuspendLayout();
            this.tpageInscribirAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcontrolAdmin
            // 
            this.tcontrolAdmin.Controls.Add(this.tpageUsers);
            this.tcontrolAdmin.Controls.Add(this.tSubject);
            this.tcontrolAdmin.Controls.Add(this.tpageModSubject);
            this.tcontrolAdmin.Controls.Add(this.tpageModifyProf);
            this.tcontrolAdmin.Controls.Add(this.tpageRegAlumn);
            this.tcontrolAdmin.Controls.Add(this.tpageInscribirAlumno);
            this.tcontrolAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcontrolAdmin.Name = "tcontrolAdmin";
            this.tcontrolAdmin.SelectedIndex = 0;
            this.tcontrolAdmin.Size = new System.Drawing.Size(405, 210);
            this.tcontrolAdmin.TabIndex = 0;
            // 
            // tpageUsers
            // 
            this.tpageUsers.Controls.Add(this.label5);
            this.tpageUsers.Controls.Add(this.label4);
            this.tpageUsers.Controls.Add(this.label3);
            this.tpageUsers.Controls.Add(this.label2);
            this.tpageUsers.Controls.Add(this.label1);
            this.tpageUsers.Controls.Add(this.txtPass);
            this.tpageUsers.Controls.Add(this.btnCrearUser);
            this.tpageUsers.Controls.Add(this.btnModify);
            this.tpageUsers.Controls.Add(this.txtDni);
            this.tpageUsers.Controls.Add(this.txtUserName);
            this.tpageUsers.Controls.Add(this.lstbUsers);
            this.tpageUsers.Controls.Add(this.txtName);
            this.tpageUsers.Controls.Add(this.cboxUserType);
            this.tpageUsers.Location = new System.Drawing.Point(4, 24);
            this.tpageUsers.Name = "tpageUsers";
            this.tpageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpageUsers.Size = new System.Drawing.Size(397, 182);
            this.tpageUsers.TabIndex = 0;
            this.tpageUsers.Text = "Users";
            this.tpageUsers.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "D.N.I.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(189, 93);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Contraseña";
            this.txtPass.Size = new System.Drawing.Size(199, 23);
            this.txtPass.TabIndex = 7;
            // 
            // btnCrearUser
            // 
            this.btnCrearUser.Location = new System.Drawing.Point(289, 151);
            this.btnCrearUser.Name = "btnCrearUser";
            this.btnCrearUser.Size = new System.Drawing.Size(99, 23);
            this.btnCrearUser.TabIndex = 6;
            this.btnCrearUser.Text = "Crear";
            this.btnCrearUser.UseVisualStyleBackColor = true;
            this.btnCrearUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(189, 151);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(99, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(189, 122);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "DNI";
            this.txtDni.Size = new System.Drawing.Size(199, 23);
            this.txtDni.TabIndex = 4;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(189, 64);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "Nombre de Usuario";
            this.txtUserName.Size = new System.Drawing.Size(199, 23);
            this.txtUserName.TabIndex = 3;
            // 
            // lstbUsers
            // 
            this.lstbUsers.FormattingEnabled = true;
            this.lstbUsers.ItemHeight = 15;
            this.lstbUsers.Location = new System.Drawing.Point(6, 6);
            this.lstbUsers.Name = "lstbUsers";
            this.lstbUsers.Size = new System.Drawing.Size(120, 169);
            this.lstbUsers.TabIndex = 2;
            this.lstbUsers.SelectedIndexChanged += new System.EventHandler(this.lstbUsers_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 6);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Nombre Completo";
            this.txtName.Size = new System.Drawing.Size(199, 23);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // cboxUserType
            // 
            this.cboxUserType.FormattingEnabled = true;
            this.cboxUserType.Location = new System.Drawing.Point(189, 35);
            this.cboxUserType.Name = "cboxUserType";
            this.cboxUserType.Size = new System.Drawing.Size(199, 23);
            this.cboxUserType.TabIndex = 0;
            // 
            // tSubject
            // 
            this.tSubject.Controls.Add(this.btnExport);
            this.tSubject.Controls.Add(this.rtxtDescMateria);
            this.tSubject.Controls.Add(this.lstbMaterias);
            this.tSubject.Location = new System.Drawing.Point(4, 24);
            this.tSubject.Name = "tSubject";
            this.tSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tSubject.Size = new System.Drawing.Size(397, 182);
            this.tSubject.TabIndex = 3;
            this.tSubject.Text = "Materias";
            this.tSubject.UseVisualStyleBackColor = true;
            // 
            // rtxtDescMateria
            // 
            this.rtxtDescMateria.Location = new System.Drawing.Point(132, 6);
            this.rtxtDescMateria.Name = "rtxtDescMateria";
            this.rtxtDescMateria.ReadOnly = true;
            this.rtxtDescMateria.Size = new System.Drawing.Size(258, 140);
            this.rtxtDescMateria.TabIndex = 1;
            this.rtxtDescMateria.Text = "";
            // 
            // lstbMaterias
            // 
            this.lstbMaterias.FormattingEnabled = true;
            this.lstbMaterias.ItemHeight = 15;
            this.lstbMaterias.Location = new System.Drawing.Point(6, 6);
            this.lstbMaterias.Name = "lstbMaterias";
            this.lstbMaterias.Size = new System.Drawing.Size(120, 169);
            this.lstbMaterias.TabIndex = 0;
            this.lstbMaterias.SelectedIndexChanged += new System.EventHandler(this.lstbMaterias_SelectedIndexChanged);
            // 
            // tpageModSubject
            // 
            this.tpageModSubject.Controls.Add(this.label10);
            this.tpageModSubject.Controls.Add(this.txtDescSubj);
            this.tpageModSubject.Controls.Add(this.label9);
            this.tpageModSubject.Controls.Add(this.label8);
            this.tpageModSubject.Controls.Add(this.label7);
            this.tpageModSubject.Controls.Add(this.label6);
            this.tpageModSubject.Controls.Add(this.chklbMaterias);
            this.tpageModSubject.Controls.Add(this.btnCrearMateria);
            this.tpageModSubject.Controls.Add(this.cbCuatri);
            this.tpageModSubject.Controls.Add(this.lstbProf);
            this.tpageModSubject.Controls.Add(this.txtCodigo);
            this.tpageModSubject.Location = new System.Drawing.Point(4, 24);
            this.tpageModSubject.Name = "tpageModSubject";
            this.tpageModSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tpageModSubject.Size = new System.Drawing.Size(397, 182);
            this.tpageModSubject.TabIndex = 1;
            this.tpageModSubject.Text = "Crear M";
            this.tpageModSubject.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descripcion";
            // 
            // txtDescSubj
            // 
            this.txtDescSubj.Location = new System.Drawing.Point(255, 121);
            this.txtDescSubj.Name = "txtDescSubj";
            this.txtDescSubj.Size = new System.Drawing.Size(132, 23);
            this.txtDescSubj.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cuatrimestre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Profesor Adjunto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correlativas";
            // 
            // chklbMaterias
            // 
            this.chklbMaterias.FormattingEnabled = true;
            this.chklbMaterias.Location = new System.Drawing.Point(3, 24);
            this.chklbMaterias.Name = "chklbMaterias";
            this.chklbMaterias.Size = new System.Drawing.Size(120, 148);
            this.chklbMaterias.TabIndex = 10;
            // 
            // btnCrearMateria
            // 
            this.btnCrearMateria.Location = new System.Drawing.Point(255, 150);
            this.btnCrearMateria.Name = "btnCrearMateria";
            this.btnCrearMateria.Size = new System.Drawing.Size(132, 26);
            this.btnCrearMateria.TabIndex = 9;
            this.btnCrearMateria.Text = "Crear";
            this.btnCrearMateria.UseVisualStyleBackColor = true;
            this.btnCrearMateria.Click += new System.EventHandler(this.btnCrearMateria_Click);
            // 
            // cbCuatri
            // 
            this.cbCuatri.FormattingEnabled = true;
            this.cbCuatri.Location = new System.Drawing.Point(255, 24);
            this.cbCuatri.Name = "cbCuatri";
            this.cbCuatri.Size = new System.Drawing.Size(132, 23);
            this.cbCuatri.TabIndex = 6;
            // 
            // lstbProf
            // 
            this.lstbProf.FormattingEnabled = true;
            this.lstbProf.ItemHeight = 15;
            this.lstbProf.Location = new System.Drawing.Point(129, 24);
            this.lstbProf.Name = "lstbProf";
            this.lstbProf.Size = new System.Drawing.Size(120, 154);
            this.lstbProf.TabIndex = 5;
            this.lstbProf.SelectedIndexChanged += new System.EventHandler(this.lstbProf_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(255, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 23);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // tpageModifyProf
            // 
            this.tpageModifyProf.Controls.Add(this.btnChangeProfessor);
            this.tpageModifyProf.Controls.Add(this.lstChangeProfesor);
            this.tpageModifyProf.Controls.Add(this.lstChangeSubject);
            this.tpageModifyProf.Location = new System.Drawing.Point(4, 24);
            this.tpageModifyProf.Name = "tpageModifyProf";
            this.tpageModifyProf.Padding = new System.Windows.Forms.Padding(3);
            this.tpageModifyProf.Size = new System.Drawing.Size(397, 182);
            this.tpageModifyProf.TabIndex = 2;
            this.tpageModifyProf.Text = "Cambiar P";
            this.tpageModifyProf.UseVisualStyleBackColor = true;
            // 
            // btnChangeProfessor
            // 
            this.btnChangeProfessor.Location = new System.Drawing.Point(258, 153);
            this.btnChangeProfessor.Name = "btnChangeProfessor";
            this.btnChangeProfessor.Size = new System.Drawing.Size(132, 23);
            this.btnChangeProfessor.TabIndex = 2;
            this.btnChangeProfessor.Text = "Cambiar";
            this.btnChangeProfessor.UseVisualStyleBackColor = true;
            this.btnChangeProfessor.Click += new System.EventHandler(this.btnChangeProfessor_Click);
            // 
            // lstChangeProfesor
            // 
            this.lstChangeProfesor.FormattingEnabled = true;
            this.lstChangeProfesor.ItemHeight = 15;
            this.lstChangeProfesor.Location = new System.Drawing.Point(132, 6);
            this.lstChangeProfesor.Name = "lstChangeProfesor";
            this.lstChangeProfesor.Size = new System.Drawing.Size(120, 169);
            this.lstChangeProfesor.TabIndex = 1;
            // 
            // lstChangeSubject
            // 
            this.lstChangeSubject.FormattingEnabled = true;
            this.lstChangeSubject.ItemHeight = 15;
            this.lstChangeSubject.Location = new System.Drawing.Point(6, 6);
            this.lstChangeSubject.Name = "lstChangeSubject";
            this.lstChangeSubject.Size = new System.Drawing.Size(120, 169);
            this.lstChangeSubject.TabIndex = 0;
            this.lstChangeSubject.SelectedIndexChanged += new System.EventHandler(this.lstChangeSubject_SelectedIndexChanged);
            // 
            // tpageRegAlumn
            // 
            this.tpageRegAlumn.Controls.Add(this.cmbRegular);
            this.tpageRegAlumn.Controls.Add(this.lblSubjectStatus);
            this.tpageRegAlumn.Controls.Add(this.btnRegularizarAlumn);
            this.tpageRegAlumn.Controls.Add(this.lstSubjectAlumns);
            this.tpageRegAlumn.Controls.Add(this.lstSubjectsToAlumns);
            this.tpageRegAlumn.Location = new System.Drawing.Point(4, 24);
            this.tpageRegAlumn.Name = "tpageRegAlumn";
            this.tpageRegAlumn.Padding = new System.Windows.Forms.Padding(3);
            this.tpageRegAlumn.Size = new System.Drawing.Size(397, 182);
            this.tpageRegAlumn.TabIndex = 4;
            this.tpageRegAlumn.Text = "Reg. Al.";
            this.tpageRegAlumn.UseVisualStyleBackColor = true;
            // 
            // cmbRegular
            // 
            this.cmbRegular.FormattingEnabled = true;
            this.cmbRegular.Items.AddRange(new object[] {
            "regular",
            "libre"});
            this.cmbRegular.Location = new System.Drawing.Point(258, 6);
            this.cmbRegular.Name = "cmbRegular";
            this.cmbRegular.Size = new System.Drawing.Size(122, 23);
            this.cmbRegular.TabIndex = 4;
            // 
            // lblSubjectStatus
            // 
            this.lblSubjectStatus.AutoSize = true;
            this.lblSubjectStatus.Location = new System.Drawing.Point(258, 6);
            this.lblSubjectStatus.Name = "lblSubjectStatus";
            this.lblSubjectStatus.Size = new System.Drawing.Size(10, 15);
            this.lblSubjectStatus.TabIndex = 3;
            this.lblSubjectStatus.Text = " ";
            // 
            // btnRegularizarAlumn
            // 
            this.btnRegularizarAlumn.Location = new System.Drawing.Point(258, 152);
            this.btnRegularizarAlumn.Name = "btnRegularizarAlumn";
            this.btnRegularizarAlumn.Size = new System.Drawing.Size(132, 23);
            this.btnRegularizarAlumn.TabIndex = 2;
            this.btnRegularizarAlumn.Text = "Cambiar Estado";
            this.btnRegularizarAlumn.UseVisualStyleBackColor = true;
            this.btnRegularizarAlumn.Click += new System.EventHandler(this.btnRegularizarAlumn_Click);
            // 
            // lstSubjectAlumns
            // 
            this.lstSubjectAlumns.FormattingEnabled = true;
            this.lstSubjectAlumns.ItemHeight = 15;
            this.lstSubjectAlumns.Location = new System.Drawing.Point(132, 6);
            this.lstSubjectAlumns.Name = "lstSubjectAlumns";
            this.lstSubjectAlumns.Size = new System.Drawing.Size(120, 169);
            this.lstSubjectAlumns.TabIndex = 1;
            this.lstSubjectAlumns.SelectedIndexChanged += new System.EventHandler(this.lstSubjectAlumns_SelectedIndexChanged);
            // 
            // lstSubjectsToAlumns
            // 
            this.lstSubjectsToAlumns.FormattingEnabled = true;
            this.lstSubjectsToAlumns.ItemHeight = 15;
            this.lstSubjectsToAlumns.Location = new System.Drawing.Point(6, 6);
            this.lstSubjectsToAlumns.Name = "lstSubjectsToAlumns";
            this.lstSubjectsToAlumns.Size = new System.Drawing.Size(120, 169);
            this.lstSubjectsToAlumns.TabIndex = 0;
            this.lstSubjectsToAlumns.SelectedIndexChanged += new System.EventHandler(this.lstSubjectsToAlumns_SelectedIndexChanged);
            // 
            // tpageInscribirAlumno
            // 
            this.tpageInscribirAlumno.Controls.Add(this.btnInscribir);
            this.tpageInscribirAlumno.Controls.Add(this.lstMateriasAlumnos);
            this.tpageInscribirAlumno.Controls.Add(this.lstAlumnos);
            this.tpageInscribirAlumno.Location = new System.Drawing.Point(4, 24);
            this.tpageInscribirAlumno.Name = "tpageInscribirAlumno";
            this.tpageInscribirAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.tpageInscribirAlumno.Size = new System.Drawing.Size(397, 182);
            this.tpageInscribirAlumno.TabIndex = 5;
            this.tpageInscribirAlumno.Text = "Inscribir Al";
            this.tpageInscribirAlumno.UseVisualStyleBackColor = true;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(258, 152);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(135, 23);
            this.btnInscribir.TabIndex = 2;
            this.btnInscribir.Text = "Inscribir Alumno";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // lstMateriasAlumnos
            // 
            this.lstMateriasAlumnos.FormattingEnabled = true;
            this.lstMateriasAlumnos.ItemHeight = 15;
            this.lstMateriasAlumnos.Location = new System.Drawing.Point(132, 6);
            this.lstMateriasAlumnos.Name = "lstMateriasAlumnos";
            this.lstMateriasAlumnos.Size = new System.Drawing.Size(120, 169);
            this.lstMateriasAlumnos.TabIndex = 1;
            this.lstMateriasAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstMateriasAlumnos_SelectedIndexChanged);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 15;
            this.lstAlumnos.Location = new System.Drawing.Point(6, 6);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(120, 169);
            this.lstAlumnos.TabIndex = 0;
            this.lstAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstAlumnos_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(132, 152);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(258, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(429, 236);
            this.Controls.Add(this.tcontrolAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(445, 275);
            this.MinimumSize = new System.Drawing.Size(445, 275);
            this.Name = "frmAdmin";
            this.Text = "Cuenta: Administrador";
            this.tcontrolAdmin.ResumeLayout(false);
            this.tpageUsers.ResumeLayout(false);
            this.tpageUsers.PerformLayout();
            this.tSubject.ResumeLayout(false);
            this.tpageModSubject.ResumeLayout(false);
            this.tpageModSubject.PerformLayout();
            this.tpageModifyProf.ResumeLayout(false);
            this.tpageRegAlumn.ResumeLayout(false);
            this.tpageRegAlumn.PerformLayout();
            this.tpageInscribirAlumno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcontrolAdmin;
        private TabPage tpageUsers;
        private TabPage tpageModSubject;
        private TabPage tpageModifyProf;
        private TextBox txtName;
        private ComboBox cboxUserType;
        private TextBox txtUserName;
        private ListBox lstbUsers;
        private Button btnCrearUser;
        private Button btnModify;
        private TextBox txtDni;
        private TextBox txtPass;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lstbProf;
        private TextBox txtCodigo;
        private ComboBox cbCuatri;
        private TabPage tSubject;
        private Button btnCrearMateria;
        private ListBox lstbMaterias;
        private CheckedListBox chklbMaterias;
        private RichTextBox rtxtDescMateria;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TabPage tpageRegAlumn;
        private Button btnChangeProfessor;
        private ListBox lstChangeProfesor;
        private ListBox lstChangeSubject;
        private Label lblSubjectStatus;
        private Button btnRegularizarAlumn;
        private ListBox lstSubjectAlumns;
        private ListBox lstSubjectsToAlumns;
        private ComboBox cmbRegular;
        private TabPage tpageInscribirAlumno;
        private Button btnInscribir;
        private ListBox lstMateriasAlumnos;
        private ListBox lstAlumnos;
        private Label label10;
        private TextBox txtDescSubj;
        private Button btnExport;
    }
}