using System;

namespace ProgramTest.Tests.Calender
{
    public class CalenderV1 : ICalender
    {
        private static int[] _days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private static int[] _daysLeap = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        private static bool IsLeap(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }

        private static bool InputIllegal(CalenderType cal)
        {
            if (cal.Year < 2000 || cal.Year > 2100)
            {
                return true;
            }

            if (cal.Month < 1 || cal.Month > 12)
            {
                return true;
            }

            if (cal.Day < 1 || cal.Day > (IsLeap(cal.Year) ? _daysLeap : _days)[cal.Month - 1])
            {
                return true;
            }

            return false;
        }

        protected override string TheNextDay(CalenderType cal)
        {
            //判断输入是否合法
            if (InputIllegal(cal))
            {
                return "您的输入非法";
            }

            var resultYear = cal.Year;
            var resultMonth = cal.Month;
            var resultDay = cal.Day + 1;

            if (resultDay > _days[resultMonth - 1])
            {
                resultMonth++;
                resultDay = 1;
            }

            if (resultMonth > 12)
            {
                resultYear++;
                resultMonth = 1;
            }

            return Convert.ToString(resultYear) + "." + Convert.ToString(resultMonth) + "." +
                   Convert.ToString(resultDay);
        }
    }
}