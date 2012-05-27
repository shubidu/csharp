using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delagates
{
    public delegate void MyDelegate(String s);
    public class MyClass
    {
        public void Hello(String str)
        {
            Console.WriteLine("Hello, {0}", str);
        }
        public static void GoodBye(String str)
        {
            Console.WriteLine("Goodbye, {0}", str);
        }
        public static void Main(string[] args)
        {
            MyClass m = new MyClass();
            
            MyDelegate a, b, c;
            a = new MyDelegate(m.Hello);
            b = MyClass.GoodBye;
            c = a + b;
            b("gosho");

            Delegate[] delegateList = c.GetInvocationList();

            foreach (var del in delegateList)
            {
                Console.WriteLine("{0} ", del.Target != m ? "True" : "False");
                if (del.Method.Name.Equals("GoodBye"))
                    ((MyDelegate) del)("Selected");
            }
        }
    }
}
