using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Student
    {
        //List<Student> students = new List<Student>();
        //public static int Id {  get; set; }
        //public static int teller = 1;
        public string Name {  get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public override string ToString()
        {  
                return Name; 
        }


        


        
    }
}
