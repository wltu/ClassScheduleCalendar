using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduleCalendar
{
    class Section : Class
    {
        public Section(String courseName)
        {
            CourseName = courseName;
        }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public String Summary => CourseName + " Section";

        public String Description { get; set; }

        public String CourseName { get; private set; }

        public List<int> Days { get; set; }
    }
}
