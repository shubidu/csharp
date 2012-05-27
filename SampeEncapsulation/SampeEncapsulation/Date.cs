// Fig. 10.9: Date.cs 
// Date class declaration.
using System;

public class Date
{
   private int month; // 1-12
   private int day; // 1-31 based on month

   // auto-implemented property Year
   public int Year { get; set; }

   // constructor: use property Month to confirm proper value for month; 
   // use property Day to confirm proper value for day
   public Date( int theMonth, int theDay, int theYear )
   {
      Month = theMonth; // validate month
      Year = theYear; // could validate year
      Day = theDay; // validate day
      Console.WriteLine( "Date object constructor for date {0}", this );
   } // end Date constructor
   public Date():this(1,1,1980)
   {

   }

   public Date(Date date)
       : this(date.month, date.day, date.Year)
   {

   }
   // property that gets and sets the month
   public int Month
   {
      get
      {
         return month;
      } // end get
      private set // make writing inaccessible outside the class
      {
         if ( value > 0 && value <= 12 ) // validate month
            month = value;
         else // month is invalid 
         {
            Console.WriteLine( "Invalid month ({0}) set to 1.", value );
            month = 1; // maintain object in consistent state
         } // end else
      } // end set
   } // end property Month

   // property that gets and sets the day
   public int Day
   {
      get
      {
         return day;
      } // end get
      private set // make writing inaccessible outside the class
      {
         int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 
                                 31, 31, 30, 31, 30, 31 };

         // check if day in range for month
         if ( value > 0 && value <= daysPerMonth[ Month ] )
            day = value;
         // check for leap year
         else if ( Month == 2 && value == 29 &&
            ( Year % 400 == 0 || ( Year % 4 == 0 && Year % 100 != 0 ) ) )
            day = value;
         else
         {
            Console.WriteLine( "Invalid day ({0}) set to 1.", value );
            day = 1; // maintain object in consistent state
         } // end else
      } // end set
   } // end property Day 

   // return a string of the form month/day/year
   public override string ToString()
   {
      return string.Format( "{0}/{1}/{2}", Month, Day, Year );
   } // end method ToString
} // end class Date


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
