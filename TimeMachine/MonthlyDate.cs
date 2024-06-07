using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;
using TimeMachine.Exceptions;

namespace TimeMachine
{
    public class MonthlyDate : IDateTimeBuilder, IDaySelector<MonthlyDate>
    {
        private const int MinYear = 1;
        private const int MaxYear = 9999;

        public Months MonthOfYear { get; }
        public DayOfMonth DayOfMonth { get; private set; }
        public int Year { get; private set; }
        private MonthlyDate(Months monthOfYear, DayOfMonth dayOfMonth)
        {
            MonthOfYear = monthOfYear;
            DayOfMonth = dayOfMonth;
            Year = DateTime.Now.Year;
        }

        public static MonthlyDate Init(Months months, DayOfMonth dayOfMonth) => new MonthlyDate(months, dayOfMonth);

        public MonthlyDate OnDay(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
            return this;
        }

        public MonthlyDate AtYear(int year)
        {
            if (year < MinYear || year > MaxYear)
                throw new InvalidYearException(year);

            Year = year;
            return this;
        }

        public DateTime LetsGo()
        {
            var day = DayOfMonth == DayOfMonth.Last
                ? DateTime.DaysInMonth(Year, (int)MonthOfYear)
                : (int)DayOfMonth;
            return new DateTime(Year, (int)MonthOfYear, day);
        }
    }
}
