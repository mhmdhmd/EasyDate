using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class Year : IDateTimeBuilder, IDaySelector<Year>
    {
        private Months _month;
        private DayOfMonth _dayOfMonth;
        private readonly int _year;
        private Year(int year)
        {
            _year = year;
            _month = Months.Jan;
            _dayOfMonth = DayOfMonth.First;
        }

        public static Year Init(int year) => new Year(year);

        public DateTime LetsGo()
        {
            var day = _dayOfMonth == DayOfMonth.Last
                ? DateTime.DaysInMonth(_year, (int)_month)
                : (int)_dayOfMonth;
            return new DateTime(_year, (int)_month, day);
        }

        public Year OnDay(DayOfMonth dayOfMonth)
        {
            _dayOfMonth = dayOfMonth;
            return this;
        }

        public Year InMonth(Months month)
        {
            _month = month;
            return this;
        }
    }
}
