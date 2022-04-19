using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class connect
    {
        public static string Connstring(string abc)
        {
            return ConfigurationManager.ConnectionStrings[abc].ConnectionString;
        }
    }
}
