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
            dbr.ConnectToDatabase();
            dbr.ReadFromDatabase();
            HTMLReportGenerator.GetMyTable(dbr.getPeople(), x => x.firstName, x=> x.lastName, x => x.telephone);

        }
    }
}
