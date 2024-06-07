using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    public class GoTo
    {
        #region DailyDate
        public static DailyDate FirstDay() => DailyDate.Init(DayOfMonth.First);
        public static DailyDate LastDay() => DailyDate.Init(DayOfMonth.Last);
        public static DailyDate Day(DayOfMonth dayOfMonth) => DailyDate.Init(dayOfMonth);
        public static DateTime Today() => DateTime.Now;
        #endregion

        #region MonthlyDate
        public static MonthlyDate FirstMonth() => MonthlyDate.Init(Months.Jan, DayOfMonth.First);
        public static MonthlyDate LastMonth() => MonthlyDate.Init(Months.Dec, DayOfMonth.First);
        public static MonthlyDate Month(Months months) => MonthlyDate.Init(months, DayOfMonth.First);
        #endregion

        #region YearlyDate
        public static YearlyDate Year(int year) => YearlyDate.Init(year); 
        #endregion
    }
}
