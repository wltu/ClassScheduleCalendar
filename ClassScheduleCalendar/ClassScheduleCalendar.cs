using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ClassScheduleCalendar
{
    public class ClassScheduleCalendar
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Class Schedule Calendar";

        private UserCredential _credential;
        private CalendarService _service;

        private string _timeZone;

        private Storage _storage;

        public Dictionary<string, string> CalendarMap { get; private set; }

        public ClassSchedule ClassSchedule { get; set; } = null;

        public ClassScheduleCalendar()
        {
            CalendarMap = new Dictionary<string, string>();
            _storage = new Storage();

            SetupAPI();
            ShowCalendarLists();
        }

        private void SetupAPI()
        {
            using (var stream = new FileStream("credentials.json",
                                                FileMode.Open,
                                                FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                this._credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            this._service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = this._credential,
                ApplicationName = ApplicationName,
            });
        }

        // List first n number of events in calendar.
        // calendarName is the key for the CalendarMap
        public void ListEvents(string calendarName, int n = 10)
        {
            string calendarId;

            if (calendarName == "primary")
                calendarId = calendarName;
            else
                calendarId = CalendarMap[calendarName];

            // Define parameters of request.
            EventsResource.ListRequest request = this._service.Events.List(calendarId);
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = n;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Upcoming events in " + calendarName + ":");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (string.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    Console.WriteLine("{0} ({1})", eventItem.Summary, when);
                }
            }
            else
            {
                Console.WriteLine("No upcoming events found.");
            }
        }

        public void ShowCalendarLists()
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

        public void SaveCalendar(string fileName)
        {
            if (this.ClassSchedule == null)
                return;

            _storage.Save(fileName, this.ClassSchedule);
        }

        public void LoadCalendar(string fileName)
        {
            this.ClassSchedule = _storage.Load(fileName);
            this.ClassSchedule.SetService(_service);
        }

        public void NewClassSchedule()
        {
            this.ClassSchedule = new ClassSchedule(_service, _timeZone);
        }

        public void NewCalendar(string name)
        {
            Calendar calendar = new Calendar()
            {
                Summary = name
            };

            _service.Calendars.Insert(calendar).Execute();
        }

        public void Export()
        {
            this.ClassSchedule.Execute();
        }

        // Assuming user can only selected existing calendars.
        // New calendar will only be seletable after creating it with NewCalender()
        public void SetCalendarID(string calendarName)
        {
            if (this.ClassSchedule == null)
                return;

            this.ClassSchedule.SetCalendarID(CalendarMap[calendarName]);
        }

        public void DeleteEvent()
        {
        }

        static void Main(string[] args)
        {
            ClassScheduleCalendar calendar = new ClassScheduleCalendar();

            calendar.ListEvents("primary");

            calendar.NewClassSchedule();

            calendar.ClassSchedule.StartDate = new DateTime(2020, 6, 15);
            calendar.ClassSchedule.NumWeeks = 3;


            string courseName = "Test";
            calendar.ClassSchedule.AddCourse(
                new Course()
                {
                    CourseName = courseName,
                    Classes = new List<Class>()
                    {
                        new Class(courseName, "Lecture")
                        {
                            StartTime = calendar.ClassSchedule.StartWeek.AddDays(2).Add(new TimeSpan(7,30,0)),
                            EndTime = calendar.ClassSchedule.StartWeek.AddDays(2).Add(new TimeSpan(8,30,0)),
                            Days = new List<int>() {2, 4}
                        },
                        new Class(courseName, "Section")
                        {
                            StartTime = calendar.ClassSchedule.StartWeek.AddDays(5).Add(new TimeSpan(7,30,0)),
                            EndTime = calendar.ClassSchedule.StartWeek.AddDays(5).Add(new TimeSpan(8,30,0)),
                            Days = new List<int>() {5}
                        }
                    }
                }
            );

            calendar.SaveCalendar("test.json");
            calendar.SetCalendarID("Test1");
            // calendar.Export();
            calendar.ListEvents("Test1");

            Console.Read();
        }
    }
}