using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class StudentTest
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 1, 2, 3, 4 };
            //int[][] jagged = { new int[] { 1, 2, 3 }, new int[] { 1 }, new int[] { 5, 5, 5, 5, 5 } };
            //int[,] arr =new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            //int l = arr.GetLength(1);
            //Student student = new Student("Ivan Petrov", 25);
            //Student student1 = new Student();
            //Student student2 = new Student(student);
           
            //Console.WriteLine(student.ToString());
            //Console.WriteLine(student1);
            //Console.WriteLine(student2);

            //Random rnd = new Random();
            

            //int[] arr2 = new int[] { 1, 2, 3, 4 };
            //int[] arr3 = new int[arr2.Length];
            //Array.Copy(arr2, arr3, arr2.Length);
            //arr3[0] = 777;
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr3[0]);
            Student student5 = new Student("Ivan Petrov",24,1600);
            Console.WriteLine(student5.AgeInFee());
            Console.WriteLine("The first letter of the name is {0}", student5.Firstchar());
            Console.WriteLine("Fee: {0}", student5.Fee);
            StudentExtension.IncreaseFee(student5, 15);
            Console.WriteLine("Fee increased with 15%: {0}", student5.Fee);
            Student one = new StudentExt("Georgi", 24, 1600,"Male");
            one.Talk();

        }
    }
}
