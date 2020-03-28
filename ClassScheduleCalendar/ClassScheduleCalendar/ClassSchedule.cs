using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduleCalendar
{
    class ClassSchedule
    {
        public ClassSchedule(CalendarService service)
        {
            Schedule = new List<Course>();
            CalendarMap = new Dictionary<String, String>();
            this.Service = service;
            ShowCalendarLists();
        }

        public Dictionary<String, String> CalendarMap { get; private set; }
        private readonly Dictionary<int, String> DaysMap = new Dictionary<int, String> {
            { 0, "SU" },
            { 1, "MO" },
            { 2, "TU" },
            { 3, "WE" },
            { 4, "TH" },
            { 5, "FR" },
            { 6, "SA" }
        };

        private CalendarService Service { get; set; }

        public String CalendarId { get; set; } = "primary";
        private String TimeZone { get; set; }

        private String RepeatEvenRules { get; set; } = "RRULE:FREQ=WEEKLY;COUNT={0};BYDAY={1}";

        public DateTime StartWeek => StartDate.AddDays(-(int)StartDate.DayOfWeek);

        public int NumWeeks { get; set; } = 1;

        public List<Course> Schedule { get; private set; }

        public DateTime StartDate { get; set; } = DateTime.Today;

        public void AddCourse(Course newCourse)
        {
            Schedule.Add(newCourse);
        }

        public void Execute()
        {
            foreach (Course course in Schedule)
            {
                foreach (Class currentClass in course.Classes)
                {
                    AddEvent(currentClass);
                }
            }
        }

        private void ShowCalendarLists()
        {
            var calendars = Service.CalendarList.List().Execute().Items;

            foreach (CalendarListEntry entry in calendars)
            {
                if (entry.Primary ?? false)
                {
                    TimeZone = entry.TimeZone;
                }

                CalendarMap[entry.Summary] = entry.Id;
                Console.WriteLine(entry.Summary + " - " + entry.Id + " - " + entry.TimeZone);
            }
        }

        private void AddCalendar(String summary)
        {
            Calendar newCalendar = new Calendar();
            newCalendar.Summary = summary;
            Service.Calendars.Insert(newCalendar).Execute();
        }

        private String ConvertDays(List<int> days)
        {
            String output = "";

            for (int i = 0; i < days.Count; i++)
            {
                output += DaysMap[days[i]];
                if (i < days.Count - 1)
                {
                    output += ",";
                }
            }

            return output;
        }

        private void AddEvent(Class currentClass)
        {
            // String summary, String description, String days, int count)
            Event newEvent = new Event()
            {
                Summary = currentClass.Summary,
                Location = currentClass.Description,
                Start = new EventDateTime()
                {
                    DateTime = currentClass.StartTime,
                    TimeZone = TimeZone
                },
                End = new EventDateTime()
                {
                    DateTime = currentClass.EndTime,
                    TimeZone = TimeZone
                },
                Recurrence = new String[] {
                    String.Format(RepeatEvenRules, currentClass.Days.Count * NumWeeks, ConvertDays(currentClass.Days))
                },
            };

            Service.Events.Insert(newEvent, CalendarId).Execute();

        }
    }

}
