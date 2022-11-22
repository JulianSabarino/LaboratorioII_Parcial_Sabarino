namespace JSabarino
{
    partial class frmSQLConn
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
            this.txtTryConn = new System.Windows.Forms.TextBox();
            this.btnTryConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTryConn
            // 
            this.txtTryConn.Location = new System.Drawing.Point(12, 12);
            this.txtTryConn.Name = "txtTryConn";
            this.txtTryConn.Size = new System.Drawing.Size(401, 23);
            this.txtTryConn.TabIndex = 0;
            this.txtTryConn.Text = "DESKTOP-AHVK8JK\\MSSQLSERVER01";
            // 
            // btnTryConn
            // 
            this.btnTryConn.Location = new System.Drawing.Point(307, 41);
            this.btnTryConn.Name = "btnTryConn";
            this.btnTryConn.Size = new System.Drawing.Size(106, 23);
            this.btnTryConn.TabIndex = 1;
            this.btnTryConn.Text = "Try Connection";
            this.btnTryConn.UseVisualStyleBackColor = true;
            this.btnTryConn.Click += new System.EventHandler(this.btnTryConn_Click);
            // 
            // frmSQLConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 77);
            this.Controls.Add(this.btnTryConn);
            this.Controls.Add(this.txtTryConn);
            this.Name = "frmSQLConn";
            this.Text = "frmSQLConn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTryConn;
        private Button btnTryConn;
    }
}