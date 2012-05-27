using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstDemoProgram
{
    class FirstProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            a += 5;
            Console.WriteLine(a);
        }
    }
}
