using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassLibraryProject
{
    public class Person
    {
        public string Name { get;  }
        int Age { get; set; } 
        public string FatherName { get; set; }
        public string Type;  
        protected internal string MotherName { get; set; } 
        protected string AddresssName { get; set; }
        internal long MobileNumber { get; set; }
        public List<string> Subjects { get; set; }
        public Person()
        {
            Type = "Human Being";
        }

    }
}
