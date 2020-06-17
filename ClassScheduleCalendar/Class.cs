using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduleCalendar
{
    public interface Class
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }

        String Summary { get; }

        String Description { get; set; }

        String CourseName { get; }

        List<int> Days { get; set; }

    }
}
