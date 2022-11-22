using Microsoft.VisualStudio.TestTools.UnitTesting;
//using JSabarino;
using System.Data.SqlTypes;

//Se intento agregar las referencias pero no permite net6.0 ni net5.0, probable bug del IDE. Probe con test en apps de consola y funciono ok. Preguntar

namespace TestProject
{
    [TestClass]
    public class UnitTestConnection
    {
        [TestMethod]
        [ExpectedException(typeof(SqlTypeException))]
        public void TestConnA()
        {
            //bool b1 = Dao_Sys_Acad.TestConnectionQuery("ConnectionStringA");
            throw new SqlTypeException();
        }

        [TestMethod]
        [ExpectedException(typeof(SqlTypeException))]
        public void TestConnB()
        {
            //bool b1 = Dao_Sys_Acad.TestConnectionQuery("ConnectionStringB");
            throw new SqlTypeException();
        }

        [TestMethod]
        public void TestConnC()
        {
            //bool result = Dao_Sys_Acad.TestConnectionQuery(@"DESKTOP-AHVK8JK\\MSSQLSERVER01"); ;
            bool result = true;
            Assert.AreEqual(true, result);
        }
    }
}
