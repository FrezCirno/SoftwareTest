namespace ProgramTest.Tests.Calender
{
    public struct CalenderType
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
    public abstract class ICalender : ITestable<CalenderType, string>
    {
        protected abstract string TheNextDay(CalenderType cal);
        public string Test(CalenderType cal)
        {
            return TheNextDay(cal);
        }
    }
}