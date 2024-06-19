using System;

namespace EasyDate
{
    public static class IntExtensions
    {
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

        public static DaySteps Days(this int day) => new DaySteps(day);
        public static WeekSteps Weeks(this int week) => new WeekSteps(week);
        public static MonthSteps Months(this int month) => new MonthSteps(month);
        public static YearSteps Years(this int year) => new YearSteps(year);

        public static DateTime InMotn<T>(this int day, int year) where T: IMonth, new()
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