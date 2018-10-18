using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreator
{
    interface DataGatherer<T>
    {
        //This method should establish connection to the server
        void ConnectToDatabase(string connection);

        // This method should read from the database and fill container 
        void ReadFromDatabase();

        // This method should return container
        List<T> GetData();
    }
}
