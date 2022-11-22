using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    public class Alumno:Persona
    {

        private List<Materia> materias;
        private Dictionary<Materia, EEstadoMateria> materiasAprobadas;
        public Alumno(string fName, string uName, int iDni):base(eUserType.alumn,fName,uName,iDni)
        {
            materias = new List<Materia>();
            materiasAprobadas = new Dictionary<Materia, EEstadoMateria>();
        }

        public Alumno(SqlDataReader reader) : base(reader)
        {
            materias = new List<Materia>();
            materiasAprobadas = new Dictionary<Materia, EEstadoMateria>();
        }

        #region GestionarMaterias
        /// <summary>
        /// Inscribe a cierto alumno a una materia, es estatico debido que es inherente de los alumnos y se usa
        /// desde los form
        /// </summary>
        /// <param name="m1">materia a inscribirse</param>
        /// <param name="a1">alumno</param>
        /// <returns>true si pudo anoterse</returns>
        public static bool InscribirMateria(Materia m1, Alumno a1)
        {
            bool isInscripted = false;
            if (a1.materias.Count < 3)
            {
                isInscripted = Dao_Sys_Acad.InsertAlumnoSubject(m1, a1);
                isInscripted &= m1.Inscribir(a1);

                if (isInscripted)
                {
                    a1.materias.Add(m1);
                }
            }
            return isInscripted;
        }

        /// <summary>
        /// Da presente a una clase concreta de una materia concreta, llama a presente de la materia.
        /// </summary>
        /// <param name="m1">materia</param>
        /// <param name="e1">evento: parcial o clase</param>
        /// <param name="a1">alumno</param>
        /// <returns>devuelve lo que retorne el dar presente</returns>
        public static bool DarAsistencia(Materia m1, Evento e1, Alumno a1)
        {
            return m1.Presente(e1, a1); ;
        }

        /// <summary>
        /// Remueve de la lista que esta cursando la materia seleccionada y la agrega a las materias aprovadas
        /// </summary>
        /// <param name="m1">materia a aprobar</param>
        /// <returns>true si pudo aprobarla</returns>
        public bool AprobarMateria(Materia m1)
        {
            bool couldAdd = false;
            if (materias.Contains(m1))
            {
                materias.Remove(m1);
                materiasAprobadas.Add(m1, EEstadoMateria.aprobado);
            }

            return couldAdd;
        }

        #endregion

        #region DevolucionesDeMaterias
        /// <summary>
        /// Devuelve la lista de materias aprobadas
        /// </summary>
        /// <returns>devuelve una lista vacia o no</returns>
        public List<Materia> MateriasAprobadas()
        {
            List<Materia> mAprobadas = new List<Materia>();
            foreach (KeyValuePair<Materia, EEstadoMateria> m1 in materiasAprobadas)
            {
                mAprobadas.Add((Materia)m1.Key);
            }
            return mAprobadas;
        }

        /// <summary>
        /// devuelve si cierta materia esta aprobada
        /// </summary>
        /// <param name="m1">materia a preguntar si esta aprobada</param>
        /// <returns>devuelve true si esta aprobada</returns>
        public bool TieneAprobado(Materia m1)
        {
            bool isAproveed = false;

            if (m1 is not null)
            {
                if (materiasAprobadas.ContainsKey(m1))
                {
                    if (materiasAprobadas[m1] == EEstadoMateria.aprobado)
                    {
                        isAproveed = true;
                    }
                }
            }
            return isAproveed;
        }

        /// <summary>
        /// devuelve la nota de una materia. Corrobora todos los parciales
        /// </summary>
        /// <param name="m1">materia a testear</param>
        /// <param name="a1">alumno a testear</param>
        /// <returns>devuelve la nota</returns>
        public static int GetNota(Materia m1, Alumno a1)
        {
            int nota = 0;
            int cantPar = 0;
            if(m1 is not null && a1 is not null)
            {
                foreach(Evento e1 in m1.RoadMap)
                {
                    if (e1.TipoEvento == tipoEvento.parcial)
                    {
                        nota += Parcial.GetAlumnNota(e1 as Parcial, a1);
                        cantPar++;
                    }
                }
                if (cantPar == 0)
                {
                    cantPar = 1;
                }
                nota = nota/cantPar;
            }
            return nota;
        }
        #endregion

        /// <summary>
        /// statico para crear alumnos de prueba
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="m1"></param>
        public static void AprobarMateriaDebug(Alumno a1, Materia m1)
        {
            a1.AprobarMateria(m1);
        }
    }
}
