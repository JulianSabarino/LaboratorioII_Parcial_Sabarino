using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSabarino.Classes
{
    public delegate string DExport(Materia m1);
    public static class dExporter
    {
        public enum EExport
        {
            csv,
            json
        }
        public static bool Exportar(Materia m1,EExport ee)
        {
            DExport? e1 = null;
            bool retValue = false;
            string fType = "";
            switch (ee)
            {
                case EExport.csv:
                    e1 = ExportCSV;
                    fType = ".csv";
                    break;
                case EExport.json:
                    e1 = ExportJSON;
                    fType = ".json";
                    break;
            }
            if (e1 is not null)
            {
                File.WriteAllText($"Exported{fType}", e1(m1));
                retValue = true;
                MessageBox.Show($"Exportado a {Environment.CurrentDirectory}","Archivo Creado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return retValue;
        }

        public static string ExportCSV(Materia m1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre,DNI,Usuario");
            if (m1.AlumnList != null)
            {
                foreach (KeyValuePair<Alumno, EEstadoMateria> a in m1.AlumnList)
                {
                    sb.AppendLine($"{a.Key.FullName},{a.Key.Dni},{a.Key.User}");
                }
            }
            return sb.ToString();
        }

        public static string ExportJSON(Materia m1)
        {
            StringBuilder sb = new StringBuilder();
            if (m1.AlumnList != null)
            {
                foreach (KeyValuePair<Alumno, EEstadoMateria> a in m1.AlumnList)
                {
                    sb.AppendLine(JsonSerializer.Serialize(a.Key));
                }
            }
            return sb.ToString();

        }
    }
}
