﻿using System;

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

        #region AM,PM
        public static DateTime AM(this DateTime dateTime) => dateTime.Hour >= 12 ? dateTime.AddHours(-12) : dateTime;
        public static DateTime PM(this DateTime dateTime) => dateTime.Hour < 12 ? dateTime.AddHours(12) : dateTime;
        #endregion

        #region Is[Day]

        public static bool IsSaturday(this DateTime datetime) => datetime.DayOfWeek == DayOfWeek.Saturday;
        public static bool IsSunday(this DateTime datetime) => datetime.DayOfWeek == DayOfWeek.Sunday;
        public static bool IsMonday(this DateTime datetime) => datetime.DayOfWeek == DayOfWeek.Monday;
        public static bool IsTuesday(this DateTime datetime) => datetime.DayOfWeek == DayOfWeek.Tuesday;
        public static bool IsWednesday(this DateTime datetime) => datetime.DayOfWeek == DayOfWeek.Wednesday;
        public static bool IsThursday(this DateTime datetime) => datetime.DayOfWeek == DayOfWeek.Thursday;
        public static bool IsFriday(this DateTime datetime) => datetime.DayOfWeek == DayOfWeek.Friday;

        #endregion

        public static DateTime NextDay(this DateTime dateTime) => dateTime.AddDays(1);
        public static DateTime PreviousDay(this DateTime dateTime) => dateTime.AddDays(-1);
    }
}