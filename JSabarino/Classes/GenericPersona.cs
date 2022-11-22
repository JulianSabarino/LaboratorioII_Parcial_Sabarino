using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    internal class UserList<U> where U : Persona
    {
        private List<U> _uList;

        public UserList()
        {
            _uList = new List<U>();
        }

        public void Add(U usuario)
        {
            _uList.Add(usuario);
        }

        public Persona? GetUser(int dni)
        {
            Persona persona = null;
            foreach (U u in _uList)
            {
                if (u.Dni == dni)
                {
                    persona = u;
                    break;
                }
            }
            return persona;
        }

        public List<U> List()
        {
            return _uList;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (U u in _uList)
            {
                sb.AppendLine(u.User);
            }

            return sb.ToString();
        }

        public List<Alumno> GetAlumnos()
        {
            List<Alumno> list = new List<Alumno>();
            foreach (U u in _uList)
            {
                if (u.UserType == eUserType.alumn)
                {
                    list.Add(u as Alumno);
                }
            }
            return list;
        }
    }
}
