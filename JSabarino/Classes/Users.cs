using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace JSabarino.Classes
{
    public static class Users
    {
        private static Dictionary<Persona,string> users = new Dictionary<Persona, string>();

        /// <summary>
        /// Recibe valores y corrobora que confirmen un log correcto, devuelve como out el tipo de usuario
        /// </summary>
        /// <param name="userName">viene de txtUsuario</param>
        /// <param name="pass">viene de txtPass</param>
        /// <param name="uType">tipo de usuario para saber que form abre, tiene "none" si la contrase;a no era correcta</param>
        /// <returns>true si el log es correcto, false si no lo es</returns>
        public static bool CorroborarLogIn(string userName, string pass, out eUserType uType, out Persona? usuarioP1)
        {
            bool exists = false;
            uType = eUserType.none;
            usuarioP1 = null;
            foreach (KeyValuePair<Persona, string> user in users)
            {
                if (user.Key.User == userName)
                {
                    exists = true;
                    if (user.Value == pass)
                    {
                        uType = user.Key.UserType;
                        usuarioP1 = user.Key;
                    }
                    break;
                }
            }
            return exists;
        }
        #region ModificacionesUsuario
        /// <summary>
        /// Cambiar el password de un usuario concreto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool CambiarPass(Persona p1, string pass)
        {
            bool couldChange = false;
            if (p1 != null && pass != null && Users.ConteinsPersona(p1))
            {
                users[p1] = pass;
                couldChange = true;
            }
            return couldChange;
        }
        /// <summary>
        /// Actualiza todos los datos de un usuario concreto, exceptuando la password
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="fName"></param>
        /// <param name="uName"></param>
        /// <param name="iDni"></param>
        /// <param name="uType"></param>
        /// <returns></returns>
        public static bool ActualizarDatos(Persona p1, string fName, string uName, int iDni, eUserType uType)
        {
            bool couldChange = false;
            if (p1 != null && fName != null && uName != null && uType != eUserType.none)
            {
                string pass = users[p1];
                users.Remove(p1);
                p1.FullName = fName;
                p1.User = uName;
                p1.Dni = iDni;
                p1.UserType = uType;

                AddUser(p1, pass);
            }
            return couldChange;
        }
        #endregion
        public static string? ReturnPass(Persona p1)
        {
            string? pass;
            users.TryGetValue(p1, out pass);

            return pass;
        }

        public static List<Persona>? ReturnPersonas()
        {
            List<Persona> list = new List<Persona>();
            foreach (KeyValuePair<Persona, string> user in users)
            {
                list.Add(user.Key); 
            }
            return list;
        }

        public static bool ConteinsPersona(Persona p1)
        {
            return users.ContainsKey(p1);
        }

        public static Dictionary<Persona, string> UserList
        {
            get { return users; }
        }
        #region AgregarQuitarUsuarios
        /// <summary>
        /// Agrega el usuario a la lista de usuarios validos
        /// </summary>
        /// <param name="p1">usuario</param>
        /// <param name="pass">contrase;a</param>
        /// <returns>true si se pudo agregar el usuario</returns>
        public static bool AddUser(Persona p1,string pass)
        {
            bool canAdd = false;
            if (!users.ContainsKey(p1) && p1 != null && pass !="")
            {
                users.Add(p1, pass);
                canAdd = true;
            }
            return canAdd;
        }

        public static bool RemovePersona(Persona p1)
        {
            return users.Remove(p1);
        }
        #endregion  


    }
}
