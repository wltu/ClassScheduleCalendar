using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
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
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        public bool Test()
        {
            return true;
        }

        static void Main(string[] args)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Adding Class Schedule Example.
            ClassSchedule classSchedule = new ClassSchedule(service)
            {
                StartDate = new DateTime(2020, 6, 15),
                NumWeeks = 3
            };

            var courseName = "Nice";
            classSchedule.AddCourse(
                new Course()
                {
                    CourseName = courseName,
                    Classes = new List<Class>()
                    {
                        new Lecture(courseName)
                        {
                            StartTime = classSchedule.StartWeek.AddDays(2).Add(new TimeSpan(7,30,0)),
                            EndTime = classSchedule.StartWeek.AddDays(2).Add(new TimeSpan(8,30,0)),
                            Days = new List<int>() {2, 4}
                        },
                        new Section(courseName)
                        {
                            StartTime = classSchedule.StartWeek.AddDays(5).Add(new TimeSpan(7,30,0)),
                            EndTime = classSchedule.StartWeek.AddDays(5).Add(new TimeSpan(8,30,0)),
                            Days = new List<int>() {5}
                        }
                    }
                }
            );

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(classSchedule.StartDate);
            Console.WriteLine(classSchedule.StartWeek);

            courseName = "NO";
            classSchedule.AddCourse(
                new Course()
                {
                    CourseName = courseName,
                    Classes = new List<Class>()
                    {
                        new Lecture(courseName)
                        {
                            StartTime =  classSchedule.StartWeek.AddDays(1).Add(new TimeSpan(10, 30, 0)),
                            EndTime = classSchedule.StartWeek.AddDays(1).Add(new TimeSpan(12, 30, 0)),
                            Days = new List<int>() {1, 3 },
                        },
                        new Lab(courseName)
                        {
                            StartTime = classSchedule.StartWeek.AddDays(5).Add(new TimeSpan(10, 30, 0)),
                            EndTime = classSchedule.StartWeek.AddDays(5).Add(new TimeSpan(12, 30, 0)),
                            Days = new List<int>() {5},
                        }
                    }
                }
            );

            classSchedule.Execute();

            //CalendarListEntry testCalendar = new CalendarListEntry();
            //testCalendar.Summary = "Test";
            //service.CalendarList.Insert(testCalendar).Execute();

            //var test = new Calendar();
            //test.Summary = "Test";
            //service.Calendars.Insert(test).Execute();



            //var ev = new Event();
            //EventDateTime start = new EventDateTime();
            //start.DateTime = new DateTime(2020, 3, 28, 10, 0, 0);
            //EventDateTime end = new EventDateTime();
            //end.DateTime = new DateTime(2020, 3, 28, 10, 30, 0);

            //ev.Start = start;
            //ev.End = end;
            //ev.Summary = "New Event";
            //ev.Description = "Description...";

            //var calendarId = "primary";
            //service.Events.Insert(ev, calendarId).Execute();


            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
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
            Console.Read();

        }
    }
}