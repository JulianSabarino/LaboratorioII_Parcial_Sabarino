using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    public interface IMateria
    {
        public int Codigo { get; }
        public string Descripcion { get; }
        public Profesor? Profesor
        {
            get;
            set;
        }
    }
}
