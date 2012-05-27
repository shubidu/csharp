using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DateLib;

namespace Schedules
{
    public class ProjectTest
    {
        private String projectTitle;
        private List<Date> deliveryDateList;

        public String ProjectTitle
        {
            get { return projectTitle; }
            set { projectTitle = value; }
        }

        public List<Date> DeliveryDateList
        {
            get
            {
                List<Date> temp = new List<Date>();
                foreach (var item in deliveryDateList)
                    temp.Add(new Date(item));
                return temp;
            }
            set
            {
                List<Date> temp = new List<Date>();
                foreach (var item in value)
                    temp.Add(new Date(item));
                
                deliveryDateList = temp;
            }
        }
        public ProjectTest()
        {
            deliveryDateList = new List<Date>();
        }

        public void Add(Date[] date)
        {
            foreach (var item in date)
                deliveryDateList.Add(new Date(item));
        }

        public override string ToString()
        {
            var sortedDesc =
                deliveryDateList.OrderByDescending(item => item.Day).OrderByDescending(item => item.Month).OrderByDescending(item => item.Year).Select(item => item);
            //var sortedDesc2 =
            //    from i in deliveryDateList
            //    orderby  i.Year descending, i.Month descending, i.Day descending
            //    select i;
                    
                    
            StringBuilder str = new StringBuilder();
            foreach (var item in sortedDesc)
                str.AppendFormat("{0}\n", item);
            return str.ToString();
        }
    }
}
