using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class YearlyDate : IDateTimeBuilder, IDaySelector<YearlyDate>
    {
        public Months MonthOfYear { get; private set; }
        public DayOfMonth DayOfMonth { get; private set; }
        public int Year { get; }
        private YearlyDate(int year)
        {
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
