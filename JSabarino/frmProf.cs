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
    public partial class frmProf : Form
    {
        private static Materia? chosenMateria;
        private static Parcial? chosenParcial;
        private static Alumno? chosenAlumno;
        public Profesor? profLogueado;
        public frmProf()
        {
            InitializeComponent();
        }

        private void frmProf_Load(object sender, EventArgs e)
        {
            ChargeMaterias();
        }

        public void ChargeMaterias()
        {
            foreach (Materia m1 in SysAcad.Materias)
            {
                if (m1.IsInThisClass(profLogueado as Profesor) || profLogueado == null)
                {
                    this.lstbMateriasPerProf.Items.Add(m1);
                }
            }
        }

        public void ChargeMatList()
        {
            lstbParcial.Items.Clear();
            if (chosenMateria is not null)
            {
                foreach (Evento rm in chosenMateria.RoadMap)
                {
                    if (rm.TipoEvento == tipoEvento.parcial)
                    {
                        this.lstbParcial.Items.Add(rm);
                    }
                }
            }
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            if (chosenMateria is not null && txtDesc.Text != "" && profLogueado != null)
            {
                string[] date = calendarEvento.SelectionStart.ToString("dd/MM/yyyy").Split('/');
                if (date.Length > 0)
                {
                    DateOnly d1 = new DateOnly(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

                    if (Profesor.CrearEvento(profLogueado, chosenMateria, txtDesc.Text, d1, chkParcial.Checked))
                    {
                        if (chkParcial.Checked)
                        {
                            MessageBox.Show($"Se creo el parcial {txtDesc} correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Se creo el evento {txtDesc} correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ChargeMatList();
            }
        }

        private void lstbMateriasPerProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenMateria = lstbMateriasPerProf.SelectedItem as Materia;
            if (chosenMateria is not null)
            {
                ChargeMatList();
            }
        }

        private void lstbParcial_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenParcial = lstbParcial.SelectedItem as Parcial;
            lstbAlumnosPresentes.Items.Clear();
            if (chosenParcial != null)
            {
                foreach (KeyValuePair<Alumno, isPresent> a1 in chosenParcial.Presente)
                {
                    if (a1.Value == isPresent.presente)
                    {
                        lstbAlumnosPresentes.Items.Add(a1.Key);
                    }
                }
            }
        }

        private void btnPonerNota_Click(object sender, EventArgs e)
        {
            if (chosenAlumno is not null && chosenParcial is not null && chosenMateria is not null)
            {
               bool respuesta = Profesor.PonerNota(chosenMateria, chosenParcial, chosenAlumno, Convert.ToInt32(Math.Round(numericNota.Value)));
                if (respuesta)
                {
                    MessageBox.Show($"Se le puso {Convert.ToInt32(Math.Round(numericNota.Value)).ToString()} al alumno {chosenAlumno}", "Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo poner nota","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void lstbAlumnosPresentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenAlumno = lstbAlumnosPresentes.SelectedItem as Alumno;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (chosenMateria is not null)
            {
                Profesor.CerrarMateria(chosenMateria);
                MessageBox.Show("Se cerro la materia y se aprobo a los correspondientes","Materia Cerrada",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnCerrarParcial_Click(object sender, EventArgs e)
        {
            if (chosenParcial is not null && chosenMateria is not null)
            {
                foreach (KeyValuePair<Alumno, EEstadoMateria> alumno in chosenMateria.AlumnList)
                {
                    if (!chosenParcial.WasPresent(alumno.Key))
                    {
                        Profesor.PonerNota(chosenMateria, chosenParcial, alumno.Key, 1);
                    }
                }
                MessageBox.Show($"Se cerro el parcial {chosenParcial}", "Parcial Cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
