using System;

namespace TimeMachine
{
    public static class GoTo
    {
        public static DailyDate FirstDay() => DailyDate.Init(DateTime.Now.Year, (MonthOfYear)DateTime.Now.Month, DayOfMonth.First);
        public static DailyDate LastDay() => DailyDate.Init(DateTime.Now.Year, (MonthOfYear)DateTime.Now.Month, (DayOfMonth)DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        public static DailyDate Day(DayOfMonth dayOfMonth) => DailyDate.Init(DateTime.Now.Year, (MonthOfYear)DateTime.Now.Month, dayOfMonth);
        public static DailyDate Today() => DailyDate.Init(DateTime.Now.Year, (MonthOfYear)DateTime.Now.Month, (DayOfMonth)DateTime.Now.Day);
        public static DailyDate Yesterday()
        {
            var yesterday = DateTime.Now.AddDays(-1);
            return DailyDate.Init(yesterday.Year, (MonthOfYear)yesterday.Month, (DayOfMonth)yesterday.Day);
        }
        public static DailyDate Tomorrow()
        {
            var tomorrow = DateTime.Now.AddDays(1);
            return DailyDate.Init(tomorrow.Year, (MonthOfYear)tomorrow.Month, (DayOfMonth)tomorrow.Day);
        }

        public static MonthlyDate FirstMonth() => MonthlyDate.Init(DateTime.Now.Year, MonthOfYear.Jan, DayOfMonth.First);
        public static MonthlyDate LastMonth() => MonthlyDate.Init(DateTime.Now.Year, MonthOfYear.Dec, DayOfMonth.First);
        public static MonthlyDate Month(MonthOfYear monthOfYear) => MonthlyDate.Init(DateTime.Now.Year, monthOfYear, DayOfMonth.First);

        public static YearlyDate Year(int year) => YearlyDate.Init(year, MonthOfYear.Jan, DayOfMonth.First);
    }
}
