using System;

namespace EasyDate
{
    public static class IntExtensions
    {
        public static DateTime OClock(this int hour, DayPeriod dayPeriod = DayPeriod.AM)
        {
            if (hour is < 1 or > 12) throw new ArgumentOutOfRangeException(nameof(hour), "The hour should be between 1 and 12");
            var datetime = DateTime.Now.At(hour);
            return dayPeriod == DayPeriod.AM ? datetime.AM() : datetime.PM();
        }

        #region Mode 1

        public static DateTime January(this int day, int year) => ClampedDateTime(year, 1, day);
        public static DateTime February(this int day, int year) => ClampedDateTime(year, 2, day);
        public static DateTime March(this int day, int year) => ClampedDateTime(year, 3, day);
        public static DateTime April(this int day, int year) => ClampedDateTime(year, 4, day);
        public static DateTime May(this int day, int year) => ClampedDateTime(year, 5, day);
        public static DateTime June(this int day, int year) => ClampedDateTime(year, 6, day);
        public static DateTime July(this int day, int year) => ClampedDateTime(year, 7, day);
        public static DateTime August(this int day, int year) => ClampedDateTime(year, 8, day);
        public static DateTime September(this int day, int year) => ClampedDateTime(year, 9, day);
        public static DateTime October(this int day, int year) => ClampedDateTime(year, 10, day);
        public static DateTime November(this int day, int year) => ClampedDateTime(year, 11, day);
        public static DateTime December(this int day, int year) => ClampedDateTime(year, 12, day);

        #endregion

        #region Mode 2

        public static DateTime January(this int day) => January(day, DateTime.Now.Year);
        public static DateTime February(this int day) => February(day, DateTime.Now.Year);
        public static DateTime March(this int day) => March(day, DateTime.Now.Year);
        public static DateTime April(this int day) => April(day, DateTime.Now.Year);
        public static DateTime May(this int day) => May(day, DateTime.Now.Year);
        public static DateTime June(this int day) => June(day, DateTime.Now.Year);
        public static DateTime July(this int day) => July(day, DateTime.Now.Year);
        public static DateTime August(this int day) => August(day, DateTime.Now.Year);
        public static DateTime September(this int day) => September(day, DateTime.Now.Year);
        public static DateTime October(this int day) => October(day, DateTime.Now.Year);
        public static DateTime November(this int day) => November(day, DateTime.Now.Year);
        public static DateTime December(this int day) => December(day, DateTime.Now.Year);        

        #endregion

        public static DaySteps Days(this int day) => new DaySteps(day);
        public static WeekSteps Weeks(this int week) => new WeekSteps(week);
        public static MonthSteps Months(this int month) => new MonthSteps(month);
        public static YearSteps Years(this int year) => new YearSteps(year);

        public static DateTime InMonth<T>(this int day, int year) where T: IMonth, new()
        {
            var month=new T();
            return ClampedDateTime(year, month.Number, day);
        }
        
        private static DateTime ClampedDateTime(int year, int month, int day)
        {
            var daysInMonth=DateTime.DaysInMonth(year, month);

            day = day.Clamp(1, daysInMonth);
            year = year.Clamp(1, 9999);

            return new DateTime(year, month, day);
        }
    }
}