using System;

namespace TimeMachine
{
    public class DailyDate : BaseDate
    {
        private DailyDate(int year, MonthOfYear month, DayOfMonth day) : base(year, month, day) { }

        public static DailyDate Init(int year, MonthOfYear month, DayOfMonth day) => new DailyDate(year, month, day);

        public MonthlyDate InMonth(MonthOfYear monthOfYear) => MonthlyDate.Init(Year, monthOfYear, DayOfMonth);
        public MonthlyDate InCurrentMonth() => MonthlyDate.Init(Year, (MonthOfYear)DateTime.Now.Month, DayOfMonth);
        public MonthlyDate InNextMonth() => MonthlyDate.Init(Year, (MonthOfYear)DateTime.Now.AddMonths(1).Month, DayOfMonth);
        public MonthlyDate InPrevMonth() => MonthlyDate.Init(Year, (MonthOfYear)DateTime.Now.AddMonths(-1).Month, DayOfMonth);
        public DailyDate DaysFromNow(int days)
        {
            var newDate = LetsGo().AddDays(days);
            return Init(newDate.Year, (MonthOfYear)newDate.Month, (DayOfMonth)newDate.Day);
        }
        public DailyDate DaysAgo(int days) => DaysFromNow(-days);
        public DailyDate InYear(int year) => Init(year, MonthOfYear, DayOfMonth);
    }
}
