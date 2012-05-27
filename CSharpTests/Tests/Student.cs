using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class Student
    {
        #region Instace Variables
        private string name;
        private int age;
        private int fee;

        public int Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        
        #endregion

        #region Constructors
        public Student(string studentName, int studentAge, int fee)
        {
            Fee = fee;
            Name = studentName;
            Age = studentAge;
        }

        public Student()
            : this("John Doe", 0, 0)
        {

        }


        public Student(Student s)
            : this(s.Name, s.Age, s.Fee)
        {

        } 
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    age = 0;
            }
        } 
        #endregion
        public void Talk()
        {
            Console.WriteLine("TALK");
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Fee: {2}", Name, Age, Fee);
        }  
    }
}
