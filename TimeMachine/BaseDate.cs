using System;

namespace TimeMachine
{
    public abstract class BaseDate : IDate
    {
        private const int MinYear = 1;
        private const int MaxYear = 9999;

        public int Year { get; protected set; }
        public Month Month { get; protected set; }
        public Day Day { get; protected set; }

        protected BaseDate(int year, Month month, Day day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public DateTime  LetsGo()
        {
            if (Year < MinYear || Year > MaxYear)
                Year = DateTime.Now.Year;

            if ((int)Day > DateTime.DaysInMonth(Year, (int)Month))
                Day = (Day)DateTime.DaysInMonth(Year, (int)Month);

            return new DateTime(Year, (int)Month, (int)Day);
        }
    }
}