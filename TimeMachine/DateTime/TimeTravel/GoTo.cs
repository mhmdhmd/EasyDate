using System;

namespace TimeMachine
{
    public static class GoTo
    {
        public static DailyDate FirstDay() => DailyDate.Init(DateTime.Now.Year, (Month)DateTime.Now.Month, TimeMachine.Day.First);
        public static DailyDate LastDay() => DailyDate.Init(DateTime.Now.Year, (Month)DateTime.Now.Month, TimeMachine.Day.Last);//(Day)DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        public static DailyDate Day(Day day) => DailyDate.Init(DateTime.Now.Year, (Month)DateTime.Now.Month, day);
        public static DailyDate Today() => DailyDate.Init(DateTime.Now.Year, (Month)DateTime.Now.Month, (Day)DateTime.Now.Day);
        public static DailyDate Yesterday()
        {
            var yesterday = DateTime.Now.AddDays(-1);
            return DailyDate.Init(yesterday.Year, (Month)yesterday.Month, (Day)yesterday.Day);
        }
        public static DailyDate Tomorrow()
        {
            var tomorrow = DateTime.Now.AddDays(1);
            return DailyDate.Init(tomorrow.Year, (Month)tomorrow.Month, (Day)tomorrow.Day);
        }

        public static MonthlyDate FirstMonth() => MonthlyDate.Init(DateTime.Now.Year, TimeMachine.Month.January, TimeMachine.Day.First);
        public static MonthlyDate LastMonth() => MonthlyDate.Init(DateTime.Now.Year, TimeMachine.Month.December, TimeMachine.Day.First);
        public static MonthlyDate Month(Month month) => MonthlyDate.Init(DateTime.Now.Year, month, TimeMachine.Day.First);

        public static YearlyDate Year(int year) => YearlyDate.Init(year, TimeMachine.Month.January, TimeMachine.Day.First);
    }
}
