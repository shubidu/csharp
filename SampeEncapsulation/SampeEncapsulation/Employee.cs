// Fig. 10.10: Employee.cs
// Employee class with references to other objects.
public class Employee
{
   private string firstName;
   private string lastName;
   private Date birthDate;
   private Date hireDate;
   private Date[] payments; // dates of payments

   // constructor to initialize name, birth date and hire date
   public Employee( string first, string last,
      Date dateOfBirth, Date dateOfHire, Date[] dates )
   {
      firstName = first;
      lastName = last;
      BirthDate = dateOfBirth;  // use the set properties!!! Mutable Reference type!
      HireDate = dateOfHire;      // use the set properties!!
      Payments = dates;     // example with an array
   } // end Employee constructor

   public Employee():this("No name", "No Name", new Date(), new Date(), new Date[]{})

   {

   }
   public Employee(Employee e)
       : this(e.firstName, e.lastName, e.birthDate, e.hireDate, e.payments)
   {

   }


   public Date[] Payments
   {
       get
       {
           Date[] copyPmts = new Date[payments.Length];
           for (int i = 0; i < copyPmts.Length; i++)
               copyPmts[i] = new Date(payments[i]);

           return copyPmts;
       }
       set
       {
           if (value != null)
           {
              payments = new Date[value.Length];
               for (int i = 0; i < payments.Length; i++)
                   payments[i] = new Date(value[i]);

           }
           else
           {
               payments = new Date[] { };
           }
       }

   }
   public Date BirthDate
   {
       get
       {
           return new Date(birthDate);
           
        }
       set
       {

           birthDate = value != null ? new Date(value) : new Date();
       }
   }
   public Date HireDate
   {
       get
       {
           return new Date(hireDate);

       }
       set
       {

           hireDate = value != null ? new Date(value) : new Date();
       }
   }

   // convert Employee to string format
   public override string ToString()
   {
      return string.Format( "{0}, {1}  Hired: {2}  Birthday: {3}",
         lastName, firstName, hireDate, birthDate );
   } // end method ToString
} // end class Employee


/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
