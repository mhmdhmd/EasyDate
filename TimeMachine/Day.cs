using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class Day
    {
        private readonly DayOfMonth _dayOfMonth;

        private Day(DayOfMonth dayOfMonth)
        {
            _dayOfMonth = dayOfMonth;
        }

        public static Day Init(DayOfMonth dayOfMonth) => new Day(dayOfMonth);
        public Month InMonth(Months month) => Month.Init(month, _dayOfMonth);
        public Month InCurrentMonth() => Month.Init((Months)DateTime.Now.Month, _dayOfMonth);
    }
}
