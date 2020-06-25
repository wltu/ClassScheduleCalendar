using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduleCalendar
{
    public class Class
    {
        public Class(string courseName, string type)
        {
            this.CourseName = courseName;
            this.Type = type;
        }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string Summary => CourseName + " " + Type;

        public string Description { get; set; }

        public string CourseName { get; set; }

        public List<int> Days { get; set; }

        public string Type { get; set; }

    }
}
