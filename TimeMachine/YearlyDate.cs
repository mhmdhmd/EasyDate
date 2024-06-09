using System;

namespace TimeMachine
{
    public class YearlyDate : BaseDate
    {
        private YearlyDate(int year, Month month, Day day) : base(year, month, day) { }
        public static YearlyDate Init(int year, Month month, Day day) => new YearlyDate(year, month, day);
        public YearlyDate OnDay(Day day)
        {
            Day = day;
            return this;
        }
        public YearlyDate InMonth(Month month)
        {
            Month = month;
            return this;
        }
        public YearlyDate YearsFromNow(int years)
        {
            var newDate = LetsGo().AddYears(years);
            return Init(newDate.Year, Month, Day);
        }
        public YearlyDate YearsAgo(int years) => YearsFromNow(-years);
        public YearlyDate DaysFromNow(int days)
        {
            var newDate = LetsGo().AddDays(days);
            return Init(newDate.Year, (Month)newDate.Month, (Day)newDate.Day);
        }
        public YearlyDate DaysAgo(int days) => DaysFromNow(-days);
        public YearlyDate MonthsFromNow(int months)
        {
            var newDate = LetsGo().AddMonths(months);
            return Init(newDate.Year, (Month)newDate.Month, Day);
        }
        public YearlyDate MonthsAgo(int months) => MonthsFromNow(-months);
    }
}
