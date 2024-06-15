using System;

namespace EasyDate
{
    public abstract class BaseDate : IDate
    {
        private const int MinYear = 1;
        private const int MaxYear = 9999;

        public int Year { get; protected set; }
        public Month Month { get; protected set; }
        public Day Day { get; protected set; }

        public int Hour { get; protected set; } = DateTime.Now.Hour;
        public int Minute { get; protected set; } = DateTime.Now.Minute;
        public int Second { get; protected set; } = DateTime.Now.Second;

        
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

            return new DateTime(Year, (int)Month, (int)Day, Hour, Minute, Second);
        }

        public BaseDate At(int hours, int minutes = 0, int seconds = 0)
        {
            Hour = hours.Clamp(0, 23);
            Minute = minutes.Clamp(0, 59);
            Second = seconds.Clamp(0, 59);
            return this;
        }

        public BaseDate At(DateTime datetime)
        {
            Hour = datetime.Hour;
            Minute = datetime.Minute;
            Second = datetime.Second;
            return this;
        }
    }
}