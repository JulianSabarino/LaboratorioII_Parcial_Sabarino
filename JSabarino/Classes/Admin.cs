using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    public sealed class Admin : Persona
    {
        public Admin(string fName, string uName, int iDni) : base(eUserType.admin, fName, uName, iDni)
        {
        }
        #region Usuarios
        /// <summary>
        /// Permite crear usuarios, se usa estatico debido a que es inherente a la clase y no a las instancias.
        /// Agrega el usuario a la lista de usuarios del proyecto.
        /// </summary>
        /// <param name="fName">Nombre completo del usuario</param>
        /// <param name="uName">Nombre de usuario</param>
        /// <param name="iDni">DNI del usuario</param>
        /// <param name="uType">tipo de usuario</param>
        /// <param name="pass">contraseña del usuario</param>
        /// <returns>True si pudo crearlo</returns>
         
        public Admin(SqlDataReader reader) : base(reader)
        { }

        public static bool CreateUser(string fName, string uName, int iDni, eUserType uType, string pass)
        {
            bool couldCreate = false;
            if (fName != null && uName != null && uType != eUserType.none && pass != null)
            {
                Persona? user = null;
                if (uType == eUserType.admin)
                {
                    user = new Admin(fName, uName, iDni);
                }
                if (uType == eUserType.prof)
                {
                    user = new Profesor(fName, uName, iDni);
                }
                if (uType == eUserType.alumn)
                {
                    user = new Alumno(fName, uName, iDni);
                }
                if (user is not null)
                {
                    couldCreate = SysAcad.AddUser(user as Persona, pass); ;
                }
            }

            return couldCreate;
        }

        /// <summary>
        /// Modifica usuario, pero no modifica la clase. Eso hay que cambiarlo a futuro
        /// </summary>
        /// <param name="p1">usuario a modificar</param>
        /// <param name="fName">nombre</param>
        /// <param name="uName">usuario</param>
        /// <param name="iDni">dni</param>
        /// <param name="uType">tipo, esto es lo que lo rompe</param>
        /// <param name="pass">contraseña</param>
        /// <returns>devuelve true si pudo modificarlo</returns>
        public static bool ModificarUser(Persona p1,string pass)
        {
            bool couldModify = false;
            if (p1 != null && SysAcad.ConteinsPersona(p1))
            {
                couldModify = SysAcad.ActualizarDatos(p1, pass);
            }
            return couldModify;
        }

        #endregion

        #region Materias
        /// <summary>
        /// Crea una materia, le asigna un profesor y lo agrega a la lista de materias del proyecto.
        /// </summary>
        /// <param name="prof">profesor adjunto</param>
        /// <param name="codigo">codigo o descripcion de la materia</param>
        /// <param name="cuatri">duracion</param>
        /// <param name="mCorrelativas">lista de materias necesarias para registrarse</param>
        /// <returns>true si pudo crearse</returns>
        public static bool CrearMateria(Profesor prof, int codigo, string cuatri, List<Materia> mCorrelativas, string desc) 
        {
            Materia m1 = new Materia(prof, codigo, cuatri, mCorrelativas,desc);

            return SysAcad.AddMateria(m1);
        }
        /// <summary>
        /// Lo mismo que la anterior, pero no crea una lista de materias necesarias para cursarla (correlativas)
        /// </summary>
        /// <param name="prof"></param>
        /// <param name="codigo"></param>
        /// <param name="cuatri"></param>
        /// <returns></returns>
        public static bool CrearMateria(Profesor prof, int codigo, string cuatri, string desc)
        {
            Materia m1 = new Materia(prof, codigo, cuatri, desc);
            
            return SysAcad.AddMateria(m1);
        }

        /// <summary>
        /// Modifica el profesor de una materia concreta
        /// </summary>
        /// <param name="m1">materia a modificar</param>
        /// <param name="p1">nuevo profesor adjunto</param>
        /// <returns>true si pudo modificarlo</returns>
        public static bool AsignarProf(Materia m1, Profesor p1)
        {
            bool couldModify = false;
            if (m1 is not null && p1 is not null)
            {
                couldModify = SysAcad.ActualizarDatos(m1, p1);
            }
            return couldModify;
        }

        #endregion

        #region EstadoAlumnos
        /// <summary>
        /// Cambia el estado de un alumno referida a una materia concreta.
        /// </summary>
        /// <param name="m1">materia</param>
        /// <param name="a1">alumno</param>
        /// <param name="r1">nuevo estado: regular o libre</param>
        /// <returns>true si pudo modificarlo</returns>
        public static bool CambiarEstadoAlumno(Materia m1, Alumno a1, EEstadoMateria r1)
        {
            bool couldChange = false;
            if (m1 is not null && a1 is not null && r1 != EEstadoMateria.noInscripto)
            {
                couldChange = m1.ChangeAlumnState(a1, r1); 
            }
            return couldChange;
        }
        #endregion
    }
}
