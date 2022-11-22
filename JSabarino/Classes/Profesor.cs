using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    public class Profesor:Persona
    {
        public Profesor(string fName, string uName, int iDni) : base(eUserType.prof, fName, uName, iDni)
        {
        }

        public Profesor(SqlDataReader reader) : base(reader)
        { }

        /// <summary>
        /// Crea un evento, si el checkbox de parcial estaba checkeado, crea un parcial en su lugar
        /// </summary>
        /// <param name="p1">profesor adjunto</param>
        /// <param name="m1">materia del evento</param>
        /// <param name="desc">descripcion del evento ej: "clase 1"</param>
        /// <param name="date">Fecha del evento</param>
        /// <param name="isParcial">si es parcial</param>
        /// <returns>devuelve true si pudo crearlo</returns>
        public static bool CrearEvento(Profesor p1, Materia m1, string desc, DateOnly date, bool isParcial)
        {

            bool couldCreate = false;

            if (p1 is not null && m1 is not null && desc is not null)
            {
                if(m1.IsInThisClass(p1))
                {
                    couldCreate = Dao_Sys_Acad.InserNewEvent(m1, date, desc, isParcial);
                    if (couldCreate)
                    {
                        int idEvento = Dao_Sys_Acad.GetEventBy(m1, date);
                        if (isParcial)
                        {
                            Parcial par1 = new Parcial(desc, date, idEvento);
                            m1.RoadMap.Add(par1);
                        }
                        else
                        {
                            Evento e1 = new Evento(desc, date, tipoEvento.clase,idEvento);
                            m1.RoadMap.Add(e1);
                        }
                    }
                }
            }

            return couldCreate;
        }

        public static bool CrearEvento(Materia m1, string desc, DateOnly date, int isParcial, int idEvento)
        {
            bool couldCreate = false;
            if (m1 is not null && m1.RoadMap is not null)
            {
                bool parcial = false;
                if (isParcial == 1)
                {
                    Parcial par1 = new Parcial(desc, date,idEvento);
                    m1.RoadMap.Add(par1);
                }
                else
                {
                    Evento e1 = new Evento(desc, date, tipoEvento.clase,idEvento);
                    m1.RoadMap.Add(e1);
                }
                couldCreate = true; 
            }
            return couldCreate;
        }

        /// <summary>
        /// Pone nota de un parcial a un alumno
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="p1"></param>
        /// <param name="a1"></param>
        /// <param name="nota"></param>
        /// <returns>devuelve si pudo poner nota al alumno</returns>
        public static bool PonerNota(Materia m1, Parcial p1, Alumno a1, int nota)
        {
            bool couldPonerNota = false;

            if (m1.IsInThisClass(a1))
            {
                if (p1.WasPresent(a1))
                {
                    m1.PonerNota(p1, a1, nota);
                }
                else
                {
                    m1.PonerNota(p1, a1, 1);
                }
                couldPonerNota = true;
            }
            return couldPonerNota;
        }

        /// <summary>
        /// Cierra una materia y aprueba a los alumnos que la tengan posible
        /// </summary>
        /// <param name="m1"></param>
        /// <returns></returns>
        public static bool CerrarMateria(Materia m1)
        {
            bool couldCerrar = false;

            if (m1 is not null)
            {
                foreach (KeyValuePair<Alumno, EEstadoMateria> alList in m1.AlumnList)
                {
                    if (Alumno.GetNota(m1,alList.Key)>=6)
                    {
                        alList.Key.AprobarMateria(m1);
                    }
                }
            }
            return couldCerrar;
        }
    }
}
