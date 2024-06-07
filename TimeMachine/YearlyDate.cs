using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;
using TimeMachine.Exceptions;

namespace TimeMachine
{
    public class YearlyDate : IDateTimeBuilder, IDaySelector<YearlyDate>
    {
        private const int MinYear = 1;
        private const int MaxYear = 9999;

        public Months MonthOfYear { get; private set; }
        public DayOfMonth DayOfMonth { get; private set; }
        public int Year { get; }
        private YearlyDate(int year)
        {
            if (year < MinYear || year > MaxYear)
                throw new InvalidYearException(year);
            
            Year = year;
            MonthOfYear = Months.Jan;
            DayOfMonth = DayOfMonth.First;
        }

        public static YearlyDate Init(int year) => new YearlyDate(year);

        public DateTime LetsGo()
        {
            var day = DayOfMonth == DayOfMonth.Last
                ? DateTime.DaysInMonth(Year, (int)MonthOfYear)
                : (int)DayOfMonth;
            return new DateTime(Year, (int)MonthOfYear, day);
        }

        public YearlyDate OnDay(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
            return this;
        }

        public YearlyDate InMonth(Months month)
        {
            MonthOfYear = month;
            return this;
        }
    }
}
