using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JSabarino.Classes
{
    public enum EEstadoMateria
    {
        aprobado=1,
        recursa,
        promocionado,
        regular,
        libre,
        noInscripto
    }
    public enum Cuatrimestre
    {
        primer,
        segundo,
        anual
    }
    public class Materia: IMateria
    {
        private int _codigo;    
        private string _cuatrimestre;
        private Profesor? _prof;
        private string _descripcion;

        private List<Materia>? correlativas;
        private Dictionary<Alumno, EEstadoMateria>? alumnoList;
        private List<Evento>? roadMap;
        

        #region Constructores
        
        public Materia(Profesor prof, int codigo, string cuatri, string desc)
        {
            this._prof = prof;
            this._codigo = codigo;            
            this._cuatrimestre = cuatri;
            this._descripcion = desc;
            alumnoList = new Dictionary<Alumno, EEstadoMateria>();
            roadMap = new List<Evento>();
            correlativas = new List<Materia>();
        }
        
        
        public Materia(Profesor prof, int codigo, string cuatri, List<Materia> mCorrelativas, string desc) : this(prof, codigo, cuatri,desc)
        {
            alumnoList = new Dictionary<Alumno, EEstadoMateria>();
            roadMap = new List<Evento>();
            correlativas = new List<Materia>();
            if (mCorrelativas is not null && mCorrelativas.Count > 0)
            {
                foreach (Materia m in mCorrelativas)
                {
                    this.correlativas.Add(m);
                }
            }

        }
        
        public Materia(SqlDataReader reader)
        {
            _codigo = reader.GetInt32(0);
            _cuatrimestre = reader.GetString(1);
            _prof = SysAcad.GetPersona(reader.GetInt32(2)) as Profesor;
            _descripcion = reader.GetString(3);
            alumnoList = new Dictionary<Alumno, EEstadoMateria>();
            roadMap = new List<Evento>();
            correlativas = new List<Materia>();
    }

        #endregion

        #region Getters
        public int Codigo
        {
            get { return _codigo; }
        }
        public string Cuatrimestre
        {
            get { return _cuatrimestre; }
        }

        public Profesor? Profesor
        {
            get { return _prof; }
            set { _prof = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public List<Materia>? Correlativas
        {
            get { return correlativas; }
        }

        public Dictionary<Alumno, EEstadoMateria>? AlumnList
        {
            get { return alumnoList; }
        }

        public List<Evento>? RoadMap
        {
            get { return roadMap; }
        }

#endregion
        /// <summary>
        /// Deja legible la informacion de una materia
        /// </summary>
        /// <returns></returns>
        public string Resterize()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {this._codigo}");
            sb.AppendLine($"Profesor: {this._prof}");
            sb.AppendLine("Materias Requeridas:");
            if (correlativas is not null && this.correlativas.Count > 0)
            {
                foreach (Materia materia in this.correlativas)
                {
                    sb.AppendLine($"\t-{materia.ToString()}");
                }
            }
            return sb.ToString();
        }

        public void AddCorrelative(Materia m1)
        {
            correlativas.Add(m1);
        }

        #region AdministrarInscripcionMateria

        /// <summary>
        /// Intenta inscribir a un alumno a esta materia
        /// </summary>
        /// <param name="a1">alumno a inscribir</param>
        /// <returns>true si se pudo inscribir</returns>
        public bool Inscribir(Alumno a1)
        {
            bool isInscribed = false;
            if (a1 != null && alumnoList is not null && !alumnoList.ContainsKey(a1) && PuedeAnotarse(this, a1))
            {
                alumnoList.Add(a1, EEstadoMateria.regular);
                isInscribed = true;
            }
            return isInscribed;
        }
        /// <summary>
        /// Se fija si un alumno se puede inscribir a una materia
        /// </summary>
        /// <param name="m1">nateria a testear</param>
        /// <param name="a1">alumno</param>
        /// <returns>true si puede inscribirse</returns>
        public static bool PuedeAnotarse(Materia m1, Alumno a1)
        {
            bool canInscribe = false;
            if (!a1.TieneAprobado(m1) && !m1.IsInThisClass(a1))
            {
                if (m1.correlativas.Count != 0)
                {
                    List<Materia> mAprobadas = a1.MateriasAprobadas();
                    foreach (Materia m in m1.correlativas)
                    {
                        if (!mAprobadas.Contains(m))
                        {
                            break;
                        }
                        canInscribe = true;
                    }
                }
                else
                {
                    canInscribe = true;
                }
            }
            return canInscribe;
        }

        #endregion

        #region AdministracionCursada
        /// <summary>
        /// Pone nota a un parcial de una materia
        /// </summary>
        /// <param name="p1">parcial</param>
        /// <param name="a1">alumno</param>
        /// <param name="nota">nota</param>
        /// <returns>devuelve true si pudo poner la nota</returns>
        public bool PonerNota(Evento p1, Alumno a1, int nota)
        {
            bool couldPutNote = false;
            if (a1 != null && p1 != null && (nota > 0 && nota <= 10) && roadMap is not null)
            {
                foreach (Evento p in roadMap)
                {
                    if (p.Date == p1.Date && p.TipoEvento == tipoEvento.parcial)
                    {
                        Parcial.PonerNota(p as Parcial, a1, nota,this);
                    }
                }
            }
            return couldPutNote;
        }
        /// <summary>
        /// Da presente a un evento de una materia
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="a1"></param>
        /// <returns></returns>
        public bool Presente(Evento e1, Alumno a1)
        {
            return Evento.GivePresent(this, e1, a1);
        }
        /// <summary>
        /// se fija si un alumno esta en la materia
        /// </summary>
        /// <param name="a1"></param>
        /// <returns></returns>
        public bool IsInThisClass(Alumno a1)
        {
            return (alumnoList is not null && alumnoList.ContainsKey(a1));
        }
        /// <summary>
        /// devuelve si el profesor es el profesor adjunto.
        /// </summary>
        /// <param name="p1"></param>
        /// <returns></returns>
        public bool IsInThisClass(Profesor p1)
        {
            return (_prof == p1);
        }

        /// <summary>
        /// se fija el estado de un alumno
        /// </summary>
        /// <param name="a1"></param>
        /// <returns>devuelve regular, libre o no inscripto</returns>
        public EEstadoMateria? AlumnState(Alumno a1)
        {
            EEstadoMateria estado = EEstadoMateria.noInscripto;
            if (alumnoList is not null && alumnoList.ContainsKey(a1))
            {
                alumnoList.TryGetValue(a1, out estado);
            }

            return estado;
        }
        /// <summary>
        /// cambia el estado de un alumno INSCRIPTO a regular o libre
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="state"></param>
        /// <returns>true si pudo ajustarlo</returns>
        public bool ChangeAlumnState(Alumno a1, EEstadoMateria state)
        {
            int iState = 6;
            if (state == EEstadoMateria.regular)
            {
                iState = 4;
            }
            if (state == EEstadoMateria.libre)
            {
                iState = 5;
            }

            bool isHere = false;

            if (a1 is not null && alumnoList is not null && alumnoList.ContainsKey(a1))
            {
                isHere = Dao_Sys_Acad.AlterAlumnState(this, a1, iState);
                if (isHere)
                {
                    alumnoList[a1] = state;
                }
            }

            return isHere;
        }

        #endregion

        /// <summary>
        /// Agrega un evento a esta materia, puede ser una clase o un parcial.
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="e1"></param>
        /// <returns></returns>
        public bool AddEvent(DateOnly d1, Evento e1)
        {
            bool canAddEvent = false;
            if (roadMap is not null)
            {
                this.roadMap.Add(e1);
                canAddEvent = true;
            }

            return canAddEvent;
        }

        #region Sobrecargas
        public override string ToString()
        {
            return this._codigo.ToString();
        }

        public static bool operator ==(Materia m1, int codigo)
        {
            return m1._codigo == codigo;
        }

        public static bool operator !=(Materia m1, int codigo)
        {
            return m1 == codigo;
        }
        #endregion

        public void AddAlumn(Alumno a1, int estado)
        {
            EEstadoMateria e1 = EEstadoMateria.noInscripto;
            if (alumnoList is null)
            {
                alumnoList = new Dictionary<Alumno, EEstadoMateria>();
            }
            switch (estado)
            {
                case 1:
                    e1 = EEstadoMateria.aprobado;
                    break;
                case 2:
                    e1 = EEstadoMateria.recursa;
                    break;
                case 3:
                    e1 = EEstadoMateria.promocionado;
                    break;
                case 4:
                    e1 = EEstadoMateria.regular;
                    break;
                case 5:
                    e1 = EEstadoMateria.libre;
                    break;
                default:
                    e1 = EEstadoMateria.noInscripto;
                    break;
            }
            alumnoList.Add(a1,e1);
        }
    }
}
