using System;

namespace TimeMachine
{
    public abstract class BaseDate : IDate
    {
        private const int MinYear = 1;
        private const int MaxYear = 9999;

        public int Year { get; protected set; }
        public MonthOfYear MonthOfYear { get; protected set; }
        public DayOfMonth DayOfMonth { get; protected set; }

        protected BaseDate(int year, MonthOfYear month, DayOfMonth day)
        {
            Year = year;
            MonthOfYear = month;
            DayOfMonth = day;
        }

        public DateTime  LetsGo()
        {
            if (Year < MinYear || Year > MaxYear)
                Year = DateTime.Now.Year;

            if ((int)DayOfMonth > DateTime.DaysInMonth(Year, (int)MonthOfYear))
                DayOfMonth = (DayOfMonth)DateTime.DaysInMonth(Year, (int)MonthOfYear);

            return new DateTime(Year, (int)MonthOfYear, (int)DayOfMonth);
        }
    }
}