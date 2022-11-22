using JSabarino.Classes;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JSabarino
{
    public partial class frmLog : Form
    {
        public Persona? usuarioLogeado;
        public frmLog()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "0";
            this.txtPass.Text = "admin";
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "2";
            this.txtPass.Text = "prof";
        }

        private void btnAlumn_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "3";
            this.txtPass.Text = "alumn";
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            eUserType uType = eUserType.none;
            int userName = int.Parse(this.txtUser.Text);
            string pass = this.txtPass.Text;
            bool exists = SysAcad.ExistsAndPasswordCorrect(userName, pass);

            if (exists)
            {
                usuarioLogeado = SysAcad.GetPersona(userName);
                if (usuarioLogeado is not null)
                {
                    uType = usuarioLogeado.UserType;
                    DialogResult frmResult;
                    switch (uType)
                    {
                        case eUserType.admin:
                            frmAdmin frmTmp = new frmAdmin();
                            frmResult = frmTmp.ShowDialog();
                            break;
                        case eUserType.prof:
                            frmProf frmProf = new frmProf();
                            frmProf.profLogueado = usuarioLogeado as Profesor;
                            frmResult = frmProf.ShowDialog();
                            break;
                        case eUserType.alumn:
                            frmAlumn frmAlumn = new frmAlumn();
                            frmAlumn.alumnLogueado = usuarioLogeado as Alumno;
                            frmResult = frmAlumn.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta","Warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No existe el usuario","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            try
            {
                Dao_Sys_Acad.GetUsersPasswords();
                Dao_Sys_Acad.GetUsers();
                Dao_Sys_Acad.GetMaterias();
                SysAcad.TryCorrelatives();
                SysAcad.TryAlumnsSubject();
                SysAcad.TryGetEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al conectarse", "SQL Conn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmSQLConn frmTmp = new frmSQLConn();
                frmTmp.ShowDialog();
            }
        }
    }
}