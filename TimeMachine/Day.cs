using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class Day
    {
        public DayOfMonth DayOfMonth { get; }

        private Day(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
        }

        public static Day Init(DayOfMonth dayOfMonth) => new Day(dayOfMonth);
        public Month InMonth(Months month) => Month.Init(month, DayOfMonth);
        public Month InCurrentMonth() => Month.Init((Months)DateTime.Now.Month, DayOfMonth);
    }
}
