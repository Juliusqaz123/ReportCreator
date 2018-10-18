using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreator
{
    // simple model class
    class Person
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string telephone { set; get; }

        public Person(string firstName, string lastName, string telephone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.telephone = telephone;
        }
    }
}
