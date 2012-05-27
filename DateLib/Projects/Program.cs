using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DateLib;


namespace Schedules
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random number = new Random();
            //Date date = new Date(1,1,1);
            //date[0] = 30;
            //date[1] = 6;
            //date[2] = 1988;
            //date.Add(8);
            //Console.WriteLine(date);

            Date[] dates = new Date[10];
            for (int i = 0; i < dates.Length; ++i)
                dates[i] = new Date(number.Next(1, 32), 5, 2009);
            ProjectTest mayProject = new ProjectTest();
            mayProject.ProjectTitle = "May Project";
            mayProject.Add(dates);
            ProjectTest juneProject = new ProjectTest();
            juneProject.ProjectTitle = "June Project";
            juneProject.DeliveryDateList = mayProject.DeliveryDateList;
            List<Date> tempList = juneProject.DeliveryDateList;
            for (int i = 0; i < juneProject.DeliveryDateList.Count; ++i)
                tempList[i].Add(13);
            juneProject.DeliveryDateList = tempList;
            
            Console.WriteLine(mayProject);
            Console.WriteLine(juneProject);
            //dates[1][2] = 2000;
            //Console.WriteLine(one);

            



            

        }
    }
}
