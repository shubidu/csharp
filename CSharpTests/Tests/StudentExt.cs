using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class StudentExt : Student
    {
        private String sex;
        
        public String Sex { get; set; }

        public StudentExt(String name, int age, int fee, String s)
            : base(name, age, fee)
        {
            Sex = s;
        }
    }
}
