using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace JSabarino.Classes
{
    public static class Dao_Sys_Acad
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static Dao_Sys_Acad()
        {
            _sqlConnection = new SqlConnection(@"Server=DESKTOP-AHVK8JK\MSSQLSERVER01;Database=Sys_Acad_Parcial;Trusted_Connection=True;");//@: tomalo literalmente

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public static void GetUsersPasswords()
        {
            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Passwords;";
                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                SysAcad.TryFillPasswords(reader);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static void GetUsers()
        {
            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Users;";
                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                SysAcad.TryFillUsers(reader);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static void GetMaterias()
        {
            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Subjects;";
                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                SysAcad.TryFillMaterias(reader);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        public static SqlDataReader? GetMaterias(int codigo)
        {
            SqlDataReader? reader = null;

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT * FROM CorrelativesSubjects WHERE CodMateria = @codigo;";
                //_sqlCommand.CommandText = "SELECT * FROM CorrelativesSubjects;";

                _sqlCommand.Parameters.AddWithValue("@codigo", codigo);

                _sqlConnection.Open();

                reader = _sqlCommand.ExecuteReader();

            }
            catch
            {
                throw new Exception("Fallo al conectar");
            }

            return reader;
        }

        public static SqlDataReader? GetMaterias(Materia m)
        {
            SqlDataReader? reader = null;

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT * FROM UserSubjects WHERE SubCod = @cod;";

                _sqlCommand.Parameters.AddWithValue("@cod", m.Codigo);

                _sqlConnection.Open();

                reader = _sqlCommand.ExecuteReader();

            }
            catch
            {
                throw new Exception("Fallo al conectar");
            }

            return reader;
        }

        public static SqlDataReader? GetEventos(Materia m)
        {
            SqlDataReader? reader = null;

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT * FROM SubectEvents WHERE idSub = @cod;";

                _sqlCommand.Parameters.AddWithValue("@cod", m.Codigo);

                _sqlConnection.Open();

                reader = _sqlCommand.ExecuteReader();

            }
            catch
            {
                throw new Exception("Fallo al conectar");
            }

            return reader;
        }

        public static bool InsertNewUser(Persona p1, string pass)
        {
            bool retValue = true;
            bool retValueB = true;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO Users (dni,userName,fName,IDUserType) VALUES(@dni,@usuario,@name,@uType);";

                _sqlCommand.Parameters.AddWithValue("@dni", p1.Dni);
                _sqlCommand.Parameters.AddWithValue("@usuario", p1.User);
                _sqlCommand.Parameters.AddWithValue("@name", p1.FullName);
                _sqlCommand.Parameters.AddWithValue("@uType", ((int)p1.UserType));

                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO Passwords (UDni,UPass) VALUES(@dni,@pass);";

                _sqlCommand.Parameters.AddWithValue("@dni", p1.Dni);
                _sqlCommand.Parameters.AddWithValue("@pass", pass);

                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValueB = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retValue&&retValueB;
        }

        public static bool InsertAlumnoSubject(Materia m1, Alumno a1)
        {
            bool retValue = true;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO UserSubjects (UAlDni,SubCod,notaU,notaD,estado) VALUES(@dni,@cod,-1,-1,4);";

                _sqlCommand.Parameters.AddWithValue("@dni", a1.Dni);
                _sqlCommand.Parameters.AddWithValue("@cod", m1.Codigo);


                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retValue;
        }

        public static bool InserNewEvent(Materia m1, DateOnly date, string desc, bool isParcial)
        {
            bool retValue = true;
            int intIsParcial=0;
            if (isParcial)
            {
                intIsParcial = 1;
            }
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO SubectEvents (idSub,fechaEv,descripcion,isParcial) VALUES(@cod,@date,@desc,@isParcial);";

                _sqlCommand.Parameters.AddWithValue("@cod", m1.Codigo);
                _sqlCommand.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                _sqlCommand.Parameters.AddWithValue("@desc", desc);
                _sqlCommand.Parameters.AddWithValue("@isParcial", intIsParcial);


                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retValue;

        }

        public static int GetEventBy(Materia m1, DateOnly date)
        {
            SqlDataReader? reader = null;
            int retValue = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT idEvento FROM SubectEvents WHERE idSub = @cod AND fechaEv = @date;";

                _sqlCommand.Parameters.AddWithValue("@cod", m1.Codigo);
                _sqlCommand.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));

                _sqlConnection.Open();

                reader = _sqlCommand.ExecuteReader();

                retValue = reader.GetInt32(0);

            }
            catch
            {
                throw new Exception("Fallo al conectar");
            }

            return retValue;

        }

        public static bool PonerNota(Parcial p1, Alumno a1, int nota, Materia m1)
        {
            bool retValue = true;
            int e1 = 2;
            if (nota > 4)
            {
                e1 = 1;
            }
            if (nota > 6)
            {
                e1 = 3;
            }

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO UserSubjects (UAlDni,SubCod,notaU,notaD,estado) VALUES(@dni,@cod,@nota,@nota,@estado);";

                _sqlCommand.Parameters.AddWithValue("@dni", a1.Dni);
                _sqlCommand.Parameters.AddWithValue("@cod", m1.Codigo);
                _sqlCommand.Parameters.AddWithValue("@nota", nota);
                _sqlCommand.Parameters.AddWithValue("@estado", e1);


                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retValue;
        }

        public static bool GivePresent(Evento e1, Alumno a1)
        {
            bool retValue = true;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO AlumnEvents (idAlumn,idEvento,isPresent) VALUES(@dni,@codEv,@isPresent);";

                _sqlCommand.Parameters.AddWithValue("@dni", a1.Dni);
                _sqlCommand.Parameters.AddWithValue("@codEv", e1.Id);
                _sqlCommand.Parameters.AddWithValue("@isPresent", "presente");

                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retValue;
        }

        public static bool AlterPass(Persona p1, string pass)
        {
            bool retValue = true;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                
                _sqlCommand.CommandText = "UPDATE Passwords SET UPass = @pass WHERE UDni = @dni;";

                _sqlCommand.Parameters.AddWithValue("@dni", p1.Dni);
                _sqlCommand.Parameters.AddWithValue("@pass", pass);

                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retValue;

        }

        public static bool AlterProfesor(Materia m1, Profesor p1)
        {
            bool retValue = true;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "UPDATE Subjects SET idProfesor = @idProf WHERE codMateria = @cod;";

                _sqlCommand.Parameters.AddWithValue("@idProf", p1.Dni);
                _sqlCommand.Parameters.AddWithValue("@cod", m1.Codigo);

                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retValue;
        }

        public static bool AlterAlumnState(Materia m1, Alumno a1, int state)
        {
            bool retValue = true;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "UPDATE UserSubjects SET estado = @state WHERE UAlDni = @dni AND SubCod = @cod;";

                _sqlCommand.Parameters.AddWithValue("@state", state);
                _sqlCommand.Parameters.AddWithValue("@dni", a1.Dni);
                _sqlCommand.Parameters.AddWithValue("@cod", m1.Codigo);

                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retValue;
        }

        public static bool InsertNewSubject(Materia m1)
        {
            bool retValue = true;
            bool retValueB = true;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO Subjects (codMateria,cuatrimestre,idProfesor,desMateria) VALUES(@codigo,@cuatri,@prof,@desc);";

                _sqlCommand.Parameters.AddWithValue("@codigo", m1.Codigo);
                _sqlCommand.Parameters.AddWithValue("@cuatri", m1.Cuatrimestre);
                _sqlCommand.Parameters.AddWithValue("@prof", m1.Profesor.Dni);
                _sqlCommand.Parameters.AddWithValue("@desc", m1.Descripcion);

                _sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                retValue = false;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            if (m1.Correlativas is not null)
            {
                foreach (Materia materia in m1.Correlativas)
                {
                    try
                    {
                        _sqlCommand.Parameters.Clear();
                        _sqlConnection.Open();

                        _sqlCommand.CommandText = "INSERT INTO CorrelativesSubjects (CodMateria,CodMateriaCorrel) VALUES(@cod,@codCorr);";

                        _sqlCommand.Parameters.AddWithValue("@cod", m1.Codigo);
                        _sqlCommand.Parameters.AddWithValue("@codCorr", materia.Codigo);

                        _sqlCommand.ExecuteNonQuery();

                    }
                    catch
                    {
                        retValueB = false;
                        break;
                    }
                    finally
                    {
                        if (_sqlConnection.State == System.Data.ConnectionState.Open)
                        {
                            _sqlConnection.Close();
                        }
                    }
                }
            }
            return retValue && retValueB;
        }

        public static void ModifyConnectionQuery(string newConn)
        {
            _sqlConnection = new SqlConnection(@$"Server={newConn};Database=Sys_Acad_Parcial;Trusted_Connection=True;");//@: tomalo literalmente
            _sqlCommand.Connection = _sqlConnection;
        }

        public static void ManuallyClose()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Open)
            {
                _sqlConnection.Close();
            }
        }

        public static bool TestConnectionQuery(string newConn)
        {
            _sqlConnection = new SqlConnection(@$"Server={newConn};Database=Sys_Acad_Parcial;Trusted_Connection=True;");//@: tomalo literalmente
            _sqlCommand.Connection = _sqlConnection;
            try
            {
                GetUsers();
            }
            catch (Exception e)
            {
                throw;
            }
            return true;
        }

    }
}
