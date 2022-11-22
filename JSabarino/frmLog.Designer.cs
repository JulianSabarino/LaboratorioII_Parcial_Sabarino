namespace JSabarino
{
    partial class frmLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.btnAlumn = new System.Windows.Forms.Button();
            this.gboxLogIn = new System.Windows.Forms.GroupBox();
            this.gboxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(6, 22);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Usuario";
            this.txtUser.Size = new System.Drawing.Size(188, 23);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 51);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "Contraseña";
            this.txtPass.Size = new System.Drawing.Size(188, 23);
            this.txtPass.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(6, 80);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(188, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(218, 21);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnProf
            // 
            this.btnProf.Location = new System.Drawing.Point(218, 50);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(75, 23);
            this.btnProf.TabIndex = 4;
            this.btnProf.Text = "Profesor";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // btnAlumn
            // 
            this.btnAlumn.Location = new System.Drawing.Point(218, 79);
            this.btnAlumn.Name = "btnAlumn";
            this.btnAlumn.Size = new System.Drawing.Size(75, 23);
            this.btnAlumn.TabIndex = 5;
            this.btnAlumn.Text = "Alumno";
            this.btnAlumn.UseVisualStyleBackColor = true;
            this.btnAlumn.Click += new System.EventHandler(this.btnAlumn_Click);
            // 
            // gboxLogIn
            // 
            this.gboxLogIn.Controls.Add(this.txtUser);
            this.gboxLogIn.Controls.Add(this.txtPass);
            this.gboxLogIn.Controls.Add(this.btnLogIn);
            this.gboxLogIn.Location = new System.Drawing.Point(12, 12);
            this.gboxLogIn.Name = "gboxLogIn";
            this.gboxLogIn.Size = new System.Drawing.Size(200, 113);
            this.gboxLogIn.TabIndex = 6;
            this.gboxLogIn.TabStop = false;
            this.gboxLogIn.Text = "Log In";
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 136);
            this.Controls.Add(this.gboxLogIn);
            this.Controls.Add(this.btnAlumn);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.btnAdmin);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 175);
            this.MinimumSize = new System.Drawing.Size(320, 175);
            this.Name = "frmLog";
            this.Text = "JSabarino";
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.gboxLogIn.ResumeLayout(false);
            this.gboxLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogIn;
        private Button btnAdmin;
        private Button btnProf;
        private Button btnAlumn;
        private GroupBox gboxLogIn;
    }
}