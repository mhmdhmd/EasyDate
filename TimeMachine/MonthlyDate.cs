using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class MonthlyDate : IDateTimeBuilder, IDaySelector<MonthlyDate>
    {
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
