using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;

namespace ClassScheduleCalendar
{
    public class ClassSchedule
    {
        public ClassSchedule(CalendarService service)
        {
            Schedule = new List<Course>();
            CalendarMap = new Dictionary<String, String>();
            this._service = service;
            ShowCalendarLists();
        }

        public ClassSchedule()
        {
            Schedule = new List<Course>();
            CalendarMap = new Dictionary<String, String>();
            this._service = null;
        }

        public void SetService(CalendarService service)
        {
            this._service = service;
            ShowCalendarLists();

        }

        public Dictionary<String, String> CalendarMap { get; private set; }

        private readonly Dictionary<int, String> _daysMap = new Dictionary<int, String> {
            { 0, "SU" },
            { 1, "MO" },
            { 2, "TU" },
            { 3, "WE" },
            { 4, "TH" },
            { 5, "FR" },
            { 6, "SA" }
        };

        private CalendarService _service { get; set; }

        public String CalendarId { get; set; } = "primary";
        private String _timeZone { get; set; }

        private String _repeatEvenRules { get; set; } = "RRULE:FREQ=WEEKLY;COUNT={0};BYDAY={1}";

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
            var calendars = _service.CalendarList.List().Execute().Items;

            foreach (CalendarListEntry entry in calendars)
            {
                if (entry.Primary ?? false)
                {
                    _timeZone = entry.TimeZone;
                }

                CalendarMap[entry.Summary] = entry.Id;
                Console.WriteLine(entry.Summary + " - " + entry.Id + " - " + entry.TimeZone);
            }
        }

        private void AddCalendar(String summary)
        {
            if (_service == null)
                return;

            Calendar newCalendar = new Calendar();
            newCalendar.Summary = summary;
            _service.Calendars.Insert(newCalendar).Execute();
        }

        public String ConvertDays(List<int> days)
        {
            String output = "";

            for (int i = 0; i < days.Count; i++)
            {
                output += _daysMap[days[i]];
                if (i < days.Count - 1)
                {
                    output += ",";
                }
            }

            return output;
        }

        private void AddEvent(Class currentClass)
        {
            if (_service == null)
                return;

            // String summary, String description, String days, int count)
            Event newEvent = new Event()
            {
                Summary = currentClass.Summary,
                Location = currentClass.Description,
                Start = new EventDateTime()
                {
                    DateTime = currentClass.StartTime,
                    TimeZone = _timeZone
                },
                End = new EventDateTime()
                {
                    DateTime = currentClass.EndTime,
                    TimeZone = _timeZone
                },
                Recurrence = new String[] {
                    String.Format(_repeatEvenRules, currentClass.Days.Count * NumWeeks, ConvertDays(currentClass.Days))
                },
            };

            _service.Events.Insert(newEvent, CalendarId).Execute();
        }
    }

}
