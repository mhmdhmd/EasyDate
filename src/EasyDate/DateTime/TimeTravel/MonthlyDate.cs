using System;

namespace EasyDate
{
    public class MonthlyDate : BaseDate
    {
        private MonthlyDate(int year, Month month, Day day) : base(year, month, day) { }
        public static MonthlyDate Init(int year, Month month, Day day) => new MonthlyDate(year, month, day);
        public MonthlyDate OnDay(Day day)
        {
            Day = day;
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
            return Init(newDate.Year, (Month)newDate.Month, Day);
        }
        public MonthlyDate MonthsAgo(int months) => MonthsFromNow(-months);
        public MonthlyDate InMonth(Month month) => Init(Year, month, Day);
        public MonthlyDate DaysFromNow(int days)
        {
            var newDate = LetsGo().AddDays(days);
            return Init(newDate.Year, (Month)newDate.Month, (Day)newDate.Day);
        }
        public MonthlyDate DaysAgo(int days) => DaysFromNow(-days);
    }
}
