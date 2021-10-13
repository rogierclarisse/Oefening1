using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Student
    {
        public string Name {  get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public override string ToString()
        {  
                return Name; 
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   Name == student.Name;
        }
    }
}
