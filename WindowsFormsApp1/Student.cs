using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        public int nr_matricol
        {
            get;set;
        }
        public string nume
        {
            get; set;
        }
        public string prenume
        {
            get; set;
        }
        public int sters2
        {
            get;set;
        }
        public string Informatii
        {
            get
            {
                return $"{nr_matricol} {nume} {prenume} ({sters2})";
            }
        }

    }
}
