using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public static class StudentExtension
    {
        public static int AgeInFee(this Student s)
        {
            int x;
            x = s.Fee / s.Age;
            return x;
        }

        public static char Firstchar(this Student s)
        {
            string str = s.Name;
            return str[0];
            
        }
        public static void IncreaseFee(this Student student, double percent)
        {
            double IncreasedFee = student.Fee + (student.Fee * (percent / 100D));
            student.Fee = (int) Math.Round(IncreasedFee);
        }
    }

}
