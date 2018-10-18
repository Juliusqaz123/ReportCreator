using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ReportCreator
{
    class DatabaseReader
    {
        private SqlConnection conn;
        List<Person> persons;

        public void ConnectToDatabase()
        {
            conn = new SqlConnection("Server=.\\localhost;Database=Person.dbo;Integrated Security=true");
            conn.Open();
        }

        public void ReadFromDatabase()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Person");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Person person = new Person(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                persons.Add(person);
            }
            conn.Close();
        }

        public List<Person> getPeople()
        {
            return persons;
        }
    }
}
