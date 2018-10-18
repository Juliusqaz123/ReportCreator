using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ReportCreator
{
    class DatabaseReader : IDatabaseReader<Person>
    {
        private SqlConnection conn;
        List<Person> persons = new List<Person>();

        public void ConnectToDatabase(string connection)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connection;
            conn.Open();
        }

        public void ReadFromDatabase()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Person", this.conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Person person = new Person(reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TelePhone"].ToString());
                        persons.Add(person);
                    }
                }

            }
            conn.Close();
        }

        public List<Person> GetData()
        {
            return persons;
        }
    }
}
