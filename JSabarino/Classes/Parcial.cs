using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    public sealed class Parcial : Evento
    {
        private Dictionary<Alumno, int> notas;
        public Parcial(string descripcion, DateOnly date,int idEvento) : base(descripcion,date, tipoEvento.parcial,idEvento)
        {
            notas = new Dictionary<Alumno, int>();
        }
        #region Notas
        /// <summary>
        /// pone la nota a un evento de tipo parcial
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="a1"></param>
        /// <param name="nota"></param>
        /// <returns></returns>
        public static bool PonerNota(Parcial p1, Alumno a1, int nota, Materia m1)
        {
            bool couldAdd = false;
            if (p1 != null && a1 != null)
            {
                couldAdd = Dao_Sys_Acad.PonerNota(p1, a1, nota,m1);
                if (couldAdd)
                {
                    p1.notas.Add(a1, nota);
                }
            }
            return couldAdd;
        }

        /// <summary>
        /// devuelve la nota del parcial de un alumno
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="a1"></param>
        /// <returns>devuelve la nota de un parcial, o 0 si no existe</returns>
        public static int GetAlumnNota(Parcial p1, Alumno a1)
        {
            int nota = 0;
            if (p1 is not null && a1 is not null)
            {
                if (p1.notas.ContainsKey(a1))
                {
                    p1.notas.TryGetValue(a1, out nota);
                }
            }
            return nota;
        }
        #endregion
        public Dictionary<Alumno, int> Notas
        {
            get { return notas;}
        }

    }
}
