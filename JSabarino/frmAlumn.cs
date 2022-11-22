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
    public partial class frmAlumn : Form
    {
        public Alumno? alumnLogueado;
        private Materia? chosenSubject;
        private Evento? chosenEvent;
        public frmAlumn()
        {
            InitializeComponent();
        }

        public void ChargeMaterias()
        {
                foreach (Materia m1 in SysAcad.Materias)
                {
                    if (m1.IsInThisClass(alumnLogueado as Alumno))
                    {
                        this.lstMateriasInscriptas.Items.Add(m1);
                    }
                    if (Materia.PuedeAnotarse(m1, alumnLogueado))
                    {
                        this.lstMateriasParaAnotarse.Items.Add(m1);
                    }
                }
        }

        public void ChargeEventos(Materia? csub)
        {
            lstEventosMateria.Items.Clear();
            if (csub is not null && csub.RoadMap is not null)
            {
                foreach (Evento e in csub.RoadMap)
                {
                    lstEventosMateria.Items.Add(e);
                }
            }
        }

        private void btnDarPresente_Click(object sender, EventArgs e)
        {
            if (alumnLogueado != null && chosenSubject is not null && chosenEvent != null)
            {
                if (Alumno.DarAsistencia(chosenSubject, chosenEvent, alumnLogueado))
                {
                    MessageBox.Show($"Se dio asistencia a {chosenSubject}:{chosenEvent}", "Asistencia correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo dar presente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmAlumn_Load(object sender, EventArgs e)
        {
            ChargeMaterias();
        }

        private void btnAnotarse_Click(object sender, EventArgs e)
        {
            if (alumnLogueado is not null && chosenSubject is not null)
            {
                if (Alumno.InscribirMateria(chosenSubject, alumnLogueado))
                {
                    MessageBox.Show($"Se inscribio a {chosenSubject}", "Inscripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al anotarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lstMateriasInscriptas_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenSubject = lstMateriasInscriptas.SelectedItem as Materia;
            ChargeEventos(chosenSubject);
            int nota = Alumno.GetNota(chosenSubject, alumnLogueado);
            if (nota > 0)
            {
                lblNota.Text = nota.ToString();
            }
            else
            {
                lblNota.Text = "Nota todavia no asignada";
            }
        }

        private void lstMateriasParaAnotarse_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenSubject = lstMateriasParaAnotarse.SelectedItem as Materia;
        }

        private void lstEventosMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenEvent = lstEventosMateria.SelectedItem as Evento;
        }
    }
}
