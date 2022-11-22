using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSabarino.Classes
{
    internal class SubjectList<M> where M : Materia
    {
        private List<M> _mList;

        public SubjectList()
        {
            _mList = new List<M>();
        }

        public void Add(M materia)
        {
            _mList.Add(materia);
        }

        public List<M> List()
        {
            return _mList;
        }

        public Materia? GetMateria(int codigo)
        {
            Materia materia = null;
            foreach (M m in _mList)
            {
                if (m.Codigo == codigo)
                {
                    materia = m;
                    break;
                }
            }
            return materia;
        }
    }
}
