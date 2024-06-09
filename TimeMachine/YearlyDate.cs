using System;

namespace TimeMachine
{
    public class YearlyDate : BaseDate
    {
        private YearlyDate(int year, MonthOfYear month, DayOfMonth day) : base(year, month, day) { }
        public static YearlyDate Init(int year, MonthOfYear month, DayOfMonth day) => new YearlyDate(year, month, day);
        public YearlyDate OnDay(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
            return this;
        }
        public YearlyDate InMonth(MonthOfYear monthOfYear)
        {
            MonthOfYear = monthOfYear;
            return this;
        }
        public YearlyDate YearsFromNow(int years)
        {
            var newDate = LetsGo().AddYears(years);
            return Init(newDate.Year, MonthOfYear, DayOfMonth);
        }
        public YearlyDate YearsAgo(int years) => YearsFromNow(-years);
        public YearlyDate DaysFromNow(int days)
        {
            var newDate = LetsGo().AddDays(days);
            return Init(newDate.Year, (MonthOfYear)newDate.Month, (DayOfMonth)newDate.Day);
        }
        public YearlyDate DaysAgo(int days) => DaysFromNow(-days);
        public YearlyDate MonthsFromNow(int months)
        {
            var newDate = LetsGo().AddMonths(months);
            return Init(newDate.Year, (MonthOfYear)newDate.Month, DayOfMonth);
        }
        public YearlyDate MonthsAgo(int months) => MonthsFromNow(-months);
    }
}
