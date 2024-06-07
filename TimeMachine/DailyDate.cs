using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class DailyDate
    {
        public DayOfMonth DayOfMonth { get; }

        private DailyDate(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
        }

        public static DailyDate Init(DayOfMonth dayOfMonth) => new DailyDate(dayOfMonth);
        public MonthlyDate InMonth(Months month) => MonthlyDate.Init(month, DayOfMonth);
        public MonthlyDate InCurrentMonth() => MonthlyDate.Init((Months)DateTime.Now.Month, DayOfMonth);
    }
}
