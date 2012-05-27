using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{

    public class Utility
    {
       
        public static int Search<T>(T[] arr, T key)
            where T : IComparable<T>
        {
            int index = -1;
            if (arr != null)
            {
                
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i].Equals(key))
                    {
                        return i;
                    }
                }
            }

            return index;
        }

        public static int[] CreateArray()
             
        {
            int[] arr = new int[10];
           
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; ++i)
                arr[i] =  rnd.Next(300);




            return arr;

        }

        public static double[] CreateArrayDbl()
        {
            double[] arr = new double[10];

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = rnd.NextDouble()*100;

            return arr;

        }

    }
}
