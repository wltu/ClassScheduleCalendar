using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassScheduleCalendarTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassScheduleCalendar.ClassScheduleCalendar x = new ClassScheduleCalendar.ClassScheduleCalendar();

            Assert.AreEqual(true, x.Test());
        }
    }
}
