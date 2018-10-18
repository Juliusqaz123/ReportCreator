using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseReader dbr = new DatabaseReader();
            HTMLReportGenerator hrg = new HTMLReportGenerator();
            dbr.ConnectToDatabase("Server=localhost;Database=Person;Trusted_Connection=true");
            dbr.ReadFromDatabase();
            hrg.TableWriter<Person>(dbr.GetData());
            

        }
    }
}
