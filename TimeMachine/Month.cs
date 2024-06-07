using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class Month : IDateTimeBuilder, IDaySelector<Month>
    {
        private readonly Months _month;
        private DayOfMonth _dayOfMonth;
        private int _year;
        private Month(Months month, DayOfMonth dayOfMonth)
        {
            _month = month;
            _dayOfMonth = dayOfMonth;
            _year = DateTime.Now.Year;
        }

        public static Month Init(Months months, DayOfMonth dayOfMonth) => new Month(months, dayOfMonth);

        public Month AtYear(int year)
        {
            _year = year;
            return this;
        }

        public DateTime LetsGo()
        {
            var day = _dayOfMonth == DayOfMonth.Last
                ? DateTime.DaysInMonth(_year, (int)_month)
                : (int)_dayOfMonth;
            return new DateTime(_year, (int)_month, day);
        }

        public Month OnDay(DayOfMonth dayOfMonth)
        {
            _dayOfMonth = dayOfMonth;
            return this;
        }
    }
}
