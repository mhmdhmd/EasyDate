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

        public BaseDate At(int hour, int minute = 0, int second = 0)
        {
            Hour = Clamp(hour, 0, 23);
            Minute = Clamp(minute, 0, 59);
            Second = Clamp(second, 0, 59);
            return this;
        }
        
        private static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            if(val.CompareTo(max) > 0) return max;
            return val;
        }
    }
}