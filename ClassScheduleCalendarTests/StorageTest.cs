using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassScheduleCalendar;
using System;
using System.Collections.Generic;

namespace ClassScheduleCalendarTests
{
    [TestClass]
    public class StorageTest
    {
        [TestMethod]
        public void TestSave()
        {
            Storage storage = new Storage();
            ClassSchedule classSchedule = new ClassSchedule()
            {
                StartDate = new DateTime(2020, 6, 15),
                NumWeeks = 3
            };
            string courseName = "TestLecture";
            classSchedule.AddCourse(
                new Course()
                {
                    CourseName = courseName,
                    Classes = new List<Class>()
                    {
                        new Class(courseName, "Lecture")
                        {
                            StartTime = classSchedule.StartWeek.AddDays(2).Add(new TimeSpan(7,30,0)),
                            EndTime = classSchedule.StartWeek.AddDays(2).Add(new TimeSpan(8,30,0)),
                            Days = new List<int>() {2, 4}
                        },
                        new Class(courseName, "Section")
                        {
                            StartTime = classSchedule.StartWeek.AddDays(5).Add(new TimeSpan(7,30,0)),
                            EndTime = classSchedule.StartWeek.AddDays(5).Add(new TimeSpan(8,30,0)),
                            Days = new List<int>() {5}
                        }
                    }
                }
            );

            storage.Save("test.json", classSchedule);

            Assert.AreEqual(true, storage.Exist("test.json"));
        }

        [TestMethod]
        public void TestLoad()
        {
            TestSave();
            Storage storage = new Storage();
            ClassSchedule classSchedule = storage.Load("test.json");

            // Course Start Informations
            Assert.AreEqual(new DateTime(2020, 6, 14), classSchedule.StartWeek);
            Assert.AreEqual(3, classSchedule.NumWeeks);
            Assert.AreEqual(new DateTime(2020, 6, 15), classSchedule.StartDate);

            // Each Individual Class Informations
            Assert.AreEqual("TestLecture", classSchedule.Schedule[0].CourseName);
            Assert.AreEqual("TestLecture Lecture", classSchedule.Schedule[0].Classes[0].Summary);
            Assert.AreEqual(classSchedule.StartWeek.AddDays(2).Add(new TimeSpan(7, 30, 0)),
                classSchedule.Schedule[0].Classes[0].StartTime);
            Assert.AreEqual(classSchedule.StartWeek.AddDays(2).Add(new TimeSpan(8, 30, 0)),
                classSchedule.Schedule[0].Classes[0].EndTime);
            Assert.AreEqual("TU,TH", classSchedule.ConvertDays(
                classSchedule.Schedule[0].Classes[0].Days
            ));

            Assert.AreEqual("TestLecture Section", classSchedule.Schedule[0].Classes[1].Summary);
            Assert.AreEqual(classSchedule.StartWeek.AddDays(5).Add(new TimeSpan(7, 30, 0)),
                classSchedule.Schedule[0].Classes[1].StartTime);
            Assert.AreEqual(classSchedule.StartWeek.AddDays(5).Add(new TimeSpan(8, 30, 0)),
                classSchedule.Schedule[0].Classes[1].EndTime);
            Assert.AreEqual("FR", classSchedule.ConvertDays(
                classSchedule.Schedule[0].Classes[1].Days
            ));
        }
    }
}
