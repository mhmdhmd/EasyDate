using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class GoTo
    {
        #region Day
        public static Day FirstDay() => Day.Init(DayOfMonth.First);
        public static Day LastDay() => Day.Init(DayOfMonth.Last);
        public static Day OnDay(DayOfMonth dayOfMonth) => Day.Init(dayOfMonth);
        public static DateTime Today() => DateTime.Now;
        #endregion

        #region Month
        public static Month FirstMonth() => Month.Init(Months.Jan, DayOfMonth.First);
        public static Month LastMonth() => Month.Init(Months.Dec, DayOfMonth.First);
        public static Month InMonth(Months months) => Month.Init(months, DayOfMonth.First);
        #endregion

        #region Year
        public static Year AtYear(int year) => Year.Init(year); 
        #endregion
    }
}
