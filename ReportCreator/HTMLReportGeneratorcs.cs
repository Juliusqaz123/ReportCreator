using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreator
{
     class HTMLReportGenerator
        {

        public void TableWriter<T>(List<Person> list)
        {
            var firstNameList = list.OrderBy(x => x.firstName).ToList();
            var lastNameList = list.OrderBy(x => x.lastName).ToList();

            PrintReport(firstNameList, "reportByFirstName.html", x => x.firstName, x => x.lastName, x => x.telephone);
            PrintReport(lastNameList, "reportByLastName.html", x => x.firstName, x => x.lastName, x => x.telephone);
        }
            
        public void PrintReport<T>(IEnumerable<T> list, string name, params Func<T, object>[] fxns)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("<TABLE>\n");
            foreach (var item in list)
            {
                sb.Append("<TR>\n");
                foreach (var fxn in fxns)
                {
                    sb.Append("<TD>");
                    sb.Append(fxn(item));
                    sb.Append("</TD>");
                }
                sb.Append("</TR>\n");
            }
            sb.Append("</TABLE>");

            System.IO.File.WriteAllText(@"C:\Users\Studentas\source\repos\ReportGenerator\ReportGenerator\" + name, sb.ToString()); ;
        }

        
    }
}
