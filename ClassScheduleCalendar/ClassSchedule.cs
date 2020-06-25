using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;

namespace ClassScheduleCalendar
{
    public class ClassSchedule
    {
        private readonly Dictionary<int, string> _daysMap = new Dictionary<int, string> {
            { 0, "SU" },
            { 1, "MO" },
            { 2, "TU" },
            { 3, "WE" },
            { 4, "TH" },
            { 5, "FR" },
            { 6, "SA" }
        };

        private CalendarService _service { get; set; }

        private string _timeZone { get; set; }

        private string _repeatEvenRules { get; set; } = "RRULE:FREQ=WEEKLY;COUNT={0};BYDAY={1}";

        public DateTime StartWeek => StartDate.AddDays(-(int)StartDate.DayOfWeek);
        private string _calendarId { get; set; } = "primary";

        public int NumWeeks { get; set; } = 1;

        public List<Course> Schedule { get; private set; }

        public DateTime StartDate { get; set; } = DateTime.Today;

        public ClassSchedule(CalendarService service)
        {
            Schedule = new List<Course>();
            this._service = service;
        }

        public ClassSchedule(CalendarService service, string timeZone)
        {
            Schedule = new List<Course>();
            this._service = service;
            this._timeZone = timeZone;
        }

        public ClassSchedule()
        {
            Schedule = new List<Course>();
            this._service = null;
        }

        public void SetService(CalendarService service)
        {
            this._service = service;
        }

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

        private void AddCalendar(string summary)
        {
            if (_service == null)
                return;

            Calendar newCalendar = new Calendar();
            newCalendar.Summary = summary;
            _service.Calendars.Insert(newCalendar).Execute();
        }

        public string ConvertDays(List<int> days)
        {
            string output = "";

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

        public void SetCalendarID(string calendarId)
        {
            this._calendarId = calendarId;
        }
        private void AddEvent(Class currentClass)
        {
            if (_service == null)
                return;

            // string summary, string description, string days, int count)
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
                Recurrence = new string[] {
                    string.Format(_repeatEvenRules, currentClass.Days.Count * NumWeeks, ConvertDays(currentClass.Days))
                },
            };

            _service.Events.Insert(newEvent, _calendarId).Execute();
        }
    }

}
