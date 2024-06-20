using System;

namespace EasyDate
{
    public static class DateTimeExtensions
    {
        public static DateTime At(this DateTime dateTime, int hours, int minutes = 0, int seconds = 0)
        {
            hours = hours.Clamp(0, 23);
            minutes = minutes.Clamp(0, 59);
            seconds = seconds.Clamp(0, 59);
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hours, minutes, seconds);
        }

        public static DateTime AM(this DateTime dateTime)
        {
            if (dateTime.Hour >= 12)
            {
                return dateTime.AddHours(-12);
            }
            return dateTime;
        }

        public static DateTime PM(this DateTime dateTime)
        {
            if (dateTime.Hour < 12)
            {
                return dateTime.AddHours(12);
            }
            return dateTime;
        }
    }
}