using System;

namespace EasyDate
{
    public class DailyDate : BaseDate
    {
        private DailyDate(int year, Month month, Day day) : base(year, month, day) { }

        public static DailyDate Init(int year, Month month, Day day) => new DailyDate(year, month, day);

        public MonthlyDate InMonth(Month month) => MonthlyDate.Init(Year, month, Day);
        public MonthlyDate InCurrentMonth() => MonthlyDate.Init(Year, (Month)DateTime.Now.Month, Day);
        public MonthlyDate InNextMonth() => MonthlyDate.Init(Year, (Month)DateTime.Now.AddMonths(1).Month, Day);
        public MonthlyDate InPrevMonth() => MonthlyDate.Init(Year, (Month)DateTime.Now.AddMonths(-1).Month, Day);
        public DailyDate DaysFromNow(int days)
        {
            var newDate = LetsGo().AddDays(days);
            return Init(newDate.Year, (Month)newDate.Month, (Day)newDate.Day);
        }
        public DailyDate DaysAgo(int days) => DaysFromNow(-days);
        public DailyDate InYear(int year) => Init(year, Month, Day);
    }
}
