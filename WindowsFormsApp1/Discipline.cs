using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Discipline
    {

        public string cod_disciplina
        {
            get; set;
        }
        public string denumire
        {
            get; set;
        }
        public int nr_credite
        {
            get; set;
        }
        public int sters
        {
            get; set;
        }
        public string Informatii
        {
            get
            {
                return $"{cod_disciplina} {denumire} {nr_credite} ({sters})";
            }
        }

    }
}
