using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    public enum isPresent
    {
        presente,
        ausente
    }
    public enum tipoEvento
    {
        parcial,
        clase
    }
    public class Evento : IEvento
    {
        private string? descripcion;
        private DateOnly date;
        private Dictionary<Alumno, isPresent> presentList;
        private tipoEvento tipoEvento;
        private int idEvento;

        public Evento(string descripcion, DateOnly date, tipoEvento tEvento, int idEvento)
        {
            this.descripcion = descripcion;
            this.date = date;
            this.tipoEvento = tEvento;
            presentList = new Dictionary<Alumno, isPresent>();
            this.idEvento = idEvento;
        }

        #region Presencialidad
        /// <summary>
        /// Da presente de un alumno concreto a un evento de una materia
        /// </summary>
        /// <param name="m1">materia</param>
        /// <param name="e1">evento de la materia</param>
        /// <param name="a1">alumno a dar presente</param>
        /// <returns>devuelve true si pudo dar el presente</returns>
        public static bool GivePresent(Materia m1, Evento e1, Alumno a1)
        {
            bool present = false;
            if (e1 is not null && a1 is not null && m1 is not null)
            {
                if (m1.IsInThisClass(a1))
                {
                    present = Dao_Sys_Acad.GivePresent(e1, a1);
                    if (present)
                    {
                        e1.presentList.Add(a1, isPresent.presente);
                    }
                }
            }
            return present;
        }

        /// <summary>
        /// Se fija si un alumno estuvo presente a este evento
        /// </summary>
        /// <param name="a1">alumno</param>
        /// <returns>devuelve true si estuvo presente</returns>
        public bool WasPresent(Alumno a1)
        {
            bool wasPresent = false;
            if (a1 != null)
            {
                wasPresent = presentList.ContainsKey(a1);
            }
            return wasPresent;
        }
        #endregion
        #region Getters
        public string? Descripcion { get { return descripcion; } }
        public DateOnly Date { get { return date; } }
        public Dictionary<Alumno, isPresent> Presente { get { return presentList; } }
        public tipoEvento TipoEvento { get { return tipoEvento; } }
        #endregion
        public override string? ToString()
        {
            return descripcion;
        }

        public int Id
        {
            get { return idEvento; }
        }
    }
}
