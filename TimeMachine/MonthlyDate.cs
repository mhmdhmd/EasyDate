using System;

namespace TimeMachine
{
    public class MonthlyDate : BaseDate
    {
        private MonthlyDate(int year, MonthOfYear month, DayOfMonth day) : base(year, month, day) { }
        public static MonthlyDate Init(int year, MonthOfYear month, DayOfMonth day) => new MonthlyDate(year, month, day);
        public MonthlyDate OnDay(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
            return this;
        }
        public MonthlyDate AtYear(int year)
        {
            Year = year;
            return this;
        }
        public MonthlyDate MonthsFromNow(int months)
        {
            var newDate = LetsGo().AddMonths(months);
            return Init(newDate.Year, (MonthOfYear)newDate.Month, DayOfMonth);
        }
        public MonthlyDate MonthsAgo(int months) => MonthsFromNow(-months);
        public MonthlyDate InMonth(MonthOfYear monthOfYear) => Init(Year, monthOfYear, DayOfMonth);
        public MonthlyDate DaysFromNow(int days)
        {
            var newDate = LetsGo().AddDays(days);
            return Init(newDate.Year, (MonthOfYear)newDate.Month, (DayOfMonth)newDate.Day);
        }
        public MonthlyDate DaysAgo(int days) => DaysFromNow(-days);
    }
}
