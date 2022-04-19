using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Diagnostics;
 

namespace WindowsFormsApp1
{
    public class AccesDate
    {
      //  public List<Student> GetStudent(string Nume)
      //  {
       //     using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
         //   {
             //   return connection.Query<Student>($"select * from studenti where nume = '{Nume}' and sters2= 0").ToList();
          //  }
     //   }//
      //  public int GetNrCredite(int a)
      //  {
       //     int nr;
       //     using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
       //     {
       //         nr= connection.Execute($"select nr_credite from discipline inner join catalog_note on  discipline.cod_disciplina = catalog_note.cod_disciplina where sters = 0 and sters3 = 0 and nota>4 and nr_matricol = '{a}'");
        //        Debug.WriteLine(a);   
        //    }
         //   return nr;
            
       // }
    //    public List<Student> GetStudentfull()
   /*     {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                return connection.Query<Student>($"select * from studenti where sters2= 0").ToList();
            }
        }
        public List<Discipline> GetDisciplinafull()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                return connection.Query<Discipline>($"select * from discipline where sters= 0").ToList();
            }
        }
        public List<Discipline> GetDisciplina(string Nume)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                return connection.Query<Discipline>($"select * from discipline where cod_disciplina = '{Nume}' and sters= 0").ToList();
            }
        }
        public List<Catalog> GetCatalog( )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                return connection.Query<Catalog>($"select * from catalog_note ").ToList();
            }
        }
        public List<Student> GetNrMatricol()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                return connection.Query<Student>($"select nr_matricol from studenti where sters2= 0").ToList();
            }
        }
        public List<Discipline> GetCodDisciplina()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                return connection.Query<Discipline>($"select cod_disciplina from discipline where sters= 0").ToList();
            }
        }
        public List<Catalog> GetCatalogcod(string Nume)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                return connection.Query<Catalog>($"select * from catalog_note where id = '{Nume}' and sters3= 0").ToList();
            }
        }

        public void InsertStudent(int nr_Matricol, string Nume, string Prenume,int Sters2)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
            

                connection.Execute($"insert into studenti (nr_matricol, nume, prenume, sters2) values ({nr_Matricol}, '{Nume}', '{Prenume}', {Sters2})");
            }
        }
        public void InsertDiscipline(string Cod_disciplina, string Denumire, int Nr_credite, int Sters)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                //  Student newstudent = new Student { nr_matricol = nr_Matricol, nume = Nume, prenume = Prenume};

                connection.Execute($"insert into discipline (cod_disciplina, denumire, nr_credite, sters) values ('{Cod_disciplina}', '{Denumire}', {Nr_credite}, {Sters})");
            }
        }
        public void DeleteStudent(string abc)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                //  Student newstudent = new Student { nr_matricol = nr_Matricol, nume = Nume, prenume = Prenume};

                connection.Execute($"Update studenti set sters2 = 1 where nr_matricol = '{abc}'");
            }
        }
        public void Deleterand(int abc)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                //  Student newstudent = new Student { nr_matricol = nr_Matricol, nume = Nume, prenume = Prenume};

                connection.Execute($"Update catalog_note set sters3 = 1 where id = '{abc}'");
            }
        }
        public void DeleteDisciplina(string abc)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {
                //  Student newstudent = new Student { nr_matricol = nr_Matricol, nume = Nume, prenume = Prenume};

                connection.Execute($"Update discipline set sters = 1 where cod_disciplina = '{abc}'");
            }
        }
        public void Insertintocatalog(string Cod_Disciplina, int Nr_Matricol, int Nota, int Sters3)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("masterDB")))
            {


                connection.Execute($"insert into catalog_note (cod_disciplina, nr_matricol, nota, sters3) values ('{Cod_Disciplina}', {Nr_Matricol}, {Nota}, {Sters3})");
            }
        }*/
       
    }
}
