using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class Month : IDateTimeBuilder, IDaySelector<Month>
    {
        public Months MonthOfYear { get; }
        public DayOfMonth DayOfMonth { get; private set; }
        public int Year { get; private set; }
        private Month(Months monthOfYear, DayOfMonth dayOfMonth)
        {
            MonthOfYear = monthOfYear;
            DayOfMonth = dayOfMonth;
            Year = DateTime.Now.Year;
        }

        public static Month Init(Months months, DayOfMonth dayOfMonth) => new Month(months, dayOfMonth);

        public Month OnDay(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
            return this;
        }

        public Month AtYear(int year)
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
