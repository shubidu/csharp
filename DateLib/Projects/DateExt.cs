using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DateLib;

namespace Schedules
{
    public static class DateExt
    {
        public static void Add(this Date date, int y)
        {
            int temp = date.Month + y;
            if(temp > 12)
            {
                date.Year += temp / 12;
                date.Month = temp % 12;
            }
           
            
        }
    }
}
