using JSabarino.Classes;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmAdmin : Form
    {
        private Persona? selectedP;
        private Materia? selectedMateria;
        public frmAdmin()
        {
            InitializeComponent();
            ChargeUsers(); //done
            ChargeUserTypes(); //done
            ChargeAlumnos(); //done

            ChargeCheckMaterias(); //done
            ChargeProfessor(); //done
            ChargeCuatrimestreTypes(); //done

        }

        #region Charge events
        private void ChargeUsers()
        {
            lstbUsers.Items.Clear();
            foreach (Persona p in SysAcad.UserList)
            {
                this.lstbUsers.Items.Add(p);
            }
        }

        private void ChargeUserTypes()
        {
            cboxUserType.Items.Add(eUserType.admin);
            cboxUserType.Items.Add(eUserType.prof);
            cboxUserType.Items.Add(eUserType.alumn);
            cboxUserType.SelectedIndex = 0;
        }

        private void ChargeAlumnos()
        {
            lstAlumnos.Items.Clear();
            foreach (Persona a1 in SysAcad.UserList)
            {
                if (a1.UserType == eUserType.alumn)
                {
                    lstAlumnos.Items.Add(a1);
                }
            }
        }

        private void ChargeCheckMaterias()
        {
            chklbMaterias.Items.Clear();
            lstbMaterias.Items.Clear();
            lstChangeSubject.Items.Clear();
            lstSubjectsToAlumns.Items.Clear();

            List<Materia> list = SysAcad.Materias;
            foreach (Materia materia in list)
            {
                this.chklbMaterias.Items.Add(materia);
                this.lstbMaterias.Items.Add(materia);
                this.lstChangeSubject.Items.Add(materia);
                this.lstSubjectsToAlumns.Items.Add(materia);
            }
        }

        private void ChargeProfessor()
        {
            lstbProf.Items.Clear();
            lstChangeProfesor.Items.Clear();

            List<Persona>? list = SysAcad.UserList;
            if (list is not null)
            {
                foreach (Persona persona in list)
                {
                    if (persona.UserType == eUserType.prof)
                    {
                        lstbProf.Items.Add(persona);
                        lstChangeProfesor.Items.Add(persona);
                    }
                }
            }
        }

        private void ChargeCuatrimestreTypes()
        {
            cbCuatri.Items.Clear();
            cbCuatri.Items.Add(Cuatrimestre.segundo);
            cbCuatri.Items.Add(Cuatrimestre.anual);
            cbCuatri.Items.Add(Cuatrimestre.primer);
            cbCuatri.SelectedIndex = 0;
        }

        private void ChargeAlumns(List<Alumno> list)
        {
            lstSubjectAlumns.Items.Clear();

            if (list is not null)
            {
                foreach (Persona persona in list)
                {
                    if (persona.UserType == eUserType.alumn)
                    {
                        lstSubjectAlumns.Items.Add(persona);
                    }
                }
            }
        }

        #endregion

        #region Crear/Modificar Usuarios

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lstbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedP = lstbUsers.SelectedItem as Persona;
            if(selectedP is not null)
            {
                this.txtName.Text = selectedP.FullName;
                this.cboxUserType.Text = selectedP.UserType.ToString();
                this.txtUserName.Text = selectedP.User;
                this.txtPass.Text = SysAcad.ReturnPass(selectedP.Dni);
                this.txtDni.Text = selectedP.Dni.ToString();             
            }
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            if (selectedP != null && txtPass.Text != "")
            {
                if (SysAcad.ConteinsPersona(selectedP))
                {
                    if (Admin.ModificarUser(selectedP, txtPass.Text))
                    {
                        MessageBox.Show("Modificado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Not Found","Object Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                ChargeUsers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" &&
                cboxUserType.Text != "" &&
                txtUserName.Text != "" &&
                txtPass.Text != "" &&
                txtDni.Text != "")
            {
                eUserType eType = eUserType.none;

                if (cboxUserType.Text == eUserType.alumn.ToString())
                {
                    eType = eUserType.alumn;
                }
                if (cboxUserType.Text == eUserType.admin.ToString())
                {
                    eType = eUserType.admin;
                }
                if (cboxUserType.Text == eUserType.prof.ToString())
                {
                    eType = eUserType.prof;
                }

                bool couldCreate = Admin.CreateUser(txtName.Text, txtUserName.Text, int.Parse(txtDni.Text), eType, txtPass.Text);
                if (couldCreate)
                {
                    MessageBox.Show($"Se creo el usuario {txtName.Text}","Se creo correctamente",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Tipo de Usuario invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                ChargeUsers();
                ChargeProfessor();
                ChargeAlumnos();
            }
        }
        #endregion

        #region Tab:CrearMaterias

        #endregion

        #region Tab:CrearMaterias2
        private void btnCrearMateria_Click(object sender, EventArgs e)
        {
            if (selectedP is not null && cbCuatri.Text != "" && txtCodigo.Text != "" && txtDescSubj.Text != "")
            {
                bool couldCreate = false;
                if (chklbMaterias.SelectedItems.Count > 0)
                {
                    List<Materia> list = new List<Materia>();
                    foreach (Materia materia in chklbMaterias.CheckedItems)
                    {
                        list.Add(materia);
                    }

                    couldCreate = Admin.CrearMateria(selectedP as Profesor, int.Parse(txtCodigo.Text), cbCuatri.Text, list,txtDescSubj.Text);
                }
                else
                {
                    couldCreate = Admin.CrearMateria(selectedP as Profesor, int.Parse(txtCodigo.Text), cbCuatri.Text,txtDescSubj.Text);
                }
                if (couldCreate)
                {
                    MessageBox.Show($"Se creo la materia {txtCodigo.Text}", "Materia Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se pudo Crear", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ChargeCheckMaterias();
            }
            else
            {
                MessageBox.Show("No se pudo agregar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lstbProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedP = lstbProf.SelectedItem as Persona;
        }

        private void lstbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMateria = lstbMaterias.SelectedItem as Materia;
            rtxtDescMateria.Text = "";
            if (selectedMateria is not null)
            {
                rtxtDescMateria.Text = selectedMateria.Resterize();
            }
        }

        private void lstChangeSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMateria = lstChangeSubject.SelectedItem as Materia;
            selectedP = lstChangeProfesor.SelectedItem as Persona;
        }

        private void btnChangeProfessor_Click(object sender, EventArgs e)
        {
            if (selectedP is not null && selectedMateria is not null)
            {
                bool retorno = Admin.AsignarProf(selectedMateria, selectedP as Profesor);
                if (retorno)
                {
                    MessageBox.Show($"Se pudo cambiar de profesor a {selectedP.ToString()}", "Cambio OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se pudo asignar el profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ChargeCheckMaterias();
        }

        #endregion

        #region Tab:Alumnos
        private void lstSubjectsToAlumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMateria = lstSubjectsToAlumns.SelectedItem as Materia;
            lstSubjectAlumns.Items.Clear();
            if (selectedMateria is not null)
            {
                Dictionary<Alumno, EEstadoMateria>? alumnList = selectedMateria.AlumnList;
                if (alumnList is not null)
                {
                    List<Alumno> alList = new List<Alumno>();
                    foreach (KeyValuePair<Alumno, EEstadoMateria> pair in alumnList)
                    {
                        if (pair.Value == EEstadoMateria.regular || pair.Value == EEstadoMateria.libre)
                        {
                            alList.Add(pair.Key);
                        }
                    }
                    ChargeAlumns(alList);
                    lblSubjectStatus.Text = "";
                }
            }
           
        }

        private void lstSubjectAlumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedP = lstSubjectAlumns.SelectedItem as Persona;
            if (selectedP is not null && selectedMateria is not null)
            {
                cmbRegular.Text = selectedMateria.AlumnState(selectedP as Alumno).ToString();
            }
        }

        private void btnRegularizarAlumn_Click(object sender, EventArgs e)
        {
            if (selectedP is not null && selectedMateria is not null)
            {
                if (selectedMateria.IsInThisClass(selectedP as Alumno));
                {
                    EEstadoMateria r1 = EEstadoMateria.noInscripto;
                    if (cmbRegular.Text == EEstadoMateria.regular.ToString())
                    {
                        r1 = EEstadoMateria.regular;
                    }
                    if (cmbRegular.Text == EEstadoMateria.libre.ToString())
                    {
                        r1 = EEstadoMateria.libre;
                    }
                    bool respuesta = Admin.CambiarEstadoAlumno(selectedMateria, selectedP as Alumno, r1);
                    if (respuesta)
                    {
                        MessageBox.Show($"Se ajusto el estado de {selectedP.ToString()} a {r1.ToString()}", "Cambio Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo ajustar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedP = lstAlumnos.SelectedItem as Alumno;
            if (selectedP is not null)
            {
                ChargeMaterias(selectedP as Alumno);
            }
        }

        private void ChargeMaterias(Alumno a1)
        {
            lstMateriasAlumnos.Items.Clear();
            foreach (Materia m1 in SysAcad.Materias)
            {
                if (Materia.PuedeAnotarse(m1, a1))
                {
                    lstMateriasAlumnos.Items.Add(m1);
                }
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (selectedP is not null && selectedMateria is not null)
            {
                if (Alumno.InscribirMateria(selectedMateria, selectedP as Alumno))
                {
                    MessageBox.Show($"Se inscribio al alumno {selectedP} a {selectedMateria}", "Inscripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al anotarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lstMateriasAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMateria = lstMateriasAlumnos.SelectedItem as Materia;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (selectedMateria is not null)
            {
                dExporter.Exportar(selectedMateria,dExporter.EExport.csv);
            }
        }
    }
}
