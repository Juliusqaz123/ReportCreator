using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreator
{
    static class HTMLReportGenerator
    {
        public static string GetMyTable<T>(IEnumerable<T> list, params Func<T, object>[] fxns)
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

            return sb.ToString();
        }
    }
}
