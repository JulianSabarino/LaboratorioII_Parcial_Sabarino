using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    public enum eUserType
    {
        admin = 1,
        prof,
        alumn,
        none
    }
    public abstract class Persona : IPersona
    {
        protected eUserType userType;
        protected string? fullName;
        protected string? userName;
        protected int dni;
        public Persona(eUserType uType, string fName, string uName, int iDni)
        {
            userType = uType;
            fullName = fName;
            userName = uName;
            dni = iDni;
        }

        public Persona(SqlDataReader reader)
        {
            dni = reader.GetInt32(0);
            userName = reader.GetString(1);
            fullName = reader.GetString(2);
            switch (reader.GetInt32(3))
            {
                case 1:
                    userType = eUserType.admin;
                    break;
                case 2:
                    userType = eUserType.prof;
                    break;
                case 3:
                    userType = eUserType.alumn;
                    break;
                default:
                    throw new Exception("Tipo de usuario inexistente");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.fullName}");

            return sb.ToString();
        }
        #region Getters
        public string? FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string? User
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public eUserType UserType
        {
            get { return this.userType; }
            set { this.userType = value;}
        }

        public int Dni
        {
            get { return this.dni;}
            set { this.dni = value;}
        }
        #endregion
    }
}
