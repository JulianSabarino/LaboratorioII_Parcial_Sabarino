using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JSabarino.Classes
{
    public static class SysAcad
    {
        private static Dictionary<int, string> _passwords = new Dictionary<int, string>();
        private static UserList<Persona> _userList = new UserList<Persona>();
        
        private static SubjectList<Materia> _materias = new SubjectList<Materia>();
        
        public static List<Persona> UserList
        {
            get { return _userList.List();}
        }
        public static List<Materia> Materias
        {
            get { return _materias.List(); }
        }

        public static bool ExistsAndPasswordCorrect(int dni,string pass)
        {
            string? tempPass;
            _passwords.TryGetValue(dni,out tempPass);
            return (_passwords.ContainsKey(dni) && (pass is not null) && (pass == tempPass));
        }

        public static bool TryFillPasswords(SqlDataReader reader)
        {
            bool retVal = true;
            try
            {
                while (reader.Read())
                {
                    _passwords.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            catch
            {
                retVal = false;
            }
            return retVal;
        }

        public static bool TryFillUsers(SqlDataReader reader)
        {
            bool retVal = true;
            try
            {
                while (reader.Read())
                {
                    eUserType userType;
                    switch (reader.GetInt32(3))
                    {
                        case 1:
                            _userList.Add(new Admin(reader));
                            break;
                        case 2:
                            _userList.Add(new Profesor(reader));
                            break;
                        case 3:
                            _userList.Add(new Alumno(reader));
                            break;
                    }
                }
            }
            catch
            {
                retVal = false;
            }
            return retVal;
        }

        public static bool TryFillMaterias(SqlDataReader reader)
        {
            bool retVal = true;
            try
            {
                while (reader.Read())
                {
                    _materias.Add(new Materia(reader));
                }
            }
            catch
            {
                retVal = false;
            }
            return retVal;
        }

        public static bool TryCorrelatives()
        {
            bool retValue = true;
            foreach (Materia m in _materias.List())
            {
                try
                {
                    SqlDataReader? readerMatCorr = Dao_Sys_Acad.GetMaterias(m.Codigo); //lista de codigo de materias correlativas
                    if (readerMatCorr is not null)
                    {
                        while (readerMatCorr.Read())
                        {
                            m.AddCorrelative(_materias.GetMateria(readerMatCorr.GetInt32(1)));//por cada codigo, lo busco en mis materias y lo agrego
                        }
                    }
                    else
                    {
                        MessageBox.Show($"La materia {m.Codigo} no tiene correlativas");
                    }
                    Dao_Sys_Acad.ManuallyClose();
                }
                catch
                {
                    retValue = false;
                }
            }
            
            return retValue;
        }

        public static bool TryAlumnsSubject()
        {
            bool retValue = true;
            foreach(Materia m in _materias.List())
            {
                SqlDataReader? readerMatCorr = Dao_Sys_Acad.GetMaterias(m); //lista de codigo de materias correlativas
                if (readerMatCorr is not null)
                {
                    while (readerMatCorr.Read())
                    {
                        m.AddAlumn(_userList.GetUser(readerMatCorr.GetInt32(0)) as Alumno,readerMatCorr.GetInt32(4));//por cada codigo, lo busco en mis materias y lo agrego
                    }
                }
                else
                {
                    MessageBox.Show($"Mucho texto");
                }
                Dao_Sys_Acad.ManuallyClose();
            }

            return retValue;
        }

        public static bool TryGetEvents()
        {
            bool retValue = true;
            foreach (Materia m in _materias.List())
            {
                SqlDataReader? reader = Dao_Sys_Acad.GetEventos(m); //lista de codigo de materias correlativas
                if (reader is not null)
                {
                    while (reader.Read())
                    {
                        DateOnly d1 = DateOnly.FromDateTime(reader.GetDateTime(1));
                        Profesor.CrearEvento(m,reader.GetString(2),d1,reader.GetInt32(3),reader.GetInt32(4));//por cada codigo, lo busco en mis materias y lo agrego
                    }
                }
                else
                {
                    MessageBox.Show($"Mucho texto");
                }
                Dao_Sys_Acad.ManuallyClose();
            }

            return retValue;
        }

        public static bool AddUser(Persona p1, string pass)
        {
            bool retVal = Dao_Sys_Acad.InsertNewUser(p1, pass);
            if (retVal)
            {
                _passwords.Add(p1.Dni,pass);
                _userList.Add(p1);
            }

            return retVal;
        }

        public static bool ActualizarDatos(Persona p1, string pass)
        {
            bool retVal = Dao_Sys_Acad.AlterPass(p1, pass);
            if (retVal)
            {
                _passwords[p1.Dni] = pass;
            }

            return retVal;
        }

        public static bool ActualizarDatos(Materia m1, Profesor p1)
        {
            bool retVal = Dao_Sys_Acad.AlterProfesor(m1, p1);
            if (retVal)
            {
                m1.Profesor = p1;
            }
            return retVal;
        }

        public static bool AddMateria(Materia m1)
        {
            bool retVal = Dao_Sys_Acad.InsertNewSubject(m1);

            return retVal;
        }

        public static Persona? GetPersona(int dni)
        {
            return _userList.GetUser(dni);
        }

        public static bool ConteinsPersona(Persona p1)
        {
            List<Persona> list = _userList.List();
            return list.Contains(p1);
        }

        public static string? ReturnPass(int dni)
        {
            string? tempPass;
            _passwords.TryGetValue(dni, out tempPass);
            return tempPass;
        }
    }
}
