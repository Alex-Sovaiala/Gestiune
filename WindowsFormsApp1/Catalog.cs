using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Catalog
    {

        public string id
        {
            get; set;
        }
        public string cod_disciplina
        {
            get; set;
        }
        public int nr_matricol
        {
            get; set;
        }
        public int nota
        {
            get; set;
        }
        public int sters3
        {
            get; set;
        }
        public string Informatii
        {
            get
            {
                return $"{id} {cod_disciplina} {nr_matricol} {nota} ({sters3})";
            }
        }

    }
}
