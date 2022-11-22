using JSabarino.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSabarino
{
    public partial class frmSQLConn : Form
    {
        public frmSQLConn()
        {
            InitializeComponent();
        }

        private void btnTryConn_Click(object sender, EventArgs e)
        {
            Dao_Sys_Acad.ModifyConnectionQuery(txtTryConn.Text);
            try
            {
                Dao_Sys_Acad.GetUsersPasswords();
                Dao_Sys_Acad.GetUsers();
                MessageBox.Show("Se conecto correctamente", "SQL Conn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al conectarse", "SQL Conn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
