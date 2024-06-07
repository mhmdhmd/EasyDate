using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;

namespace TimeMachine
{
    /// <summary>
    /// Represents a date with a specified day of the month.
    /// </summary>
    public class DailyDate
    {
        /// <summary>
        /// Gets the day of the month.
        /// </summary>
        public DayOfMonth DayOfMonth { get; }

        private DailyDate(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDate"/> class with the specified day of the month.
        /// </summary>
        /// <param name="dayOfMonth">The day of the month.</param>
        /// <returns>A new instance of the <see cref="DailyDate"/> class.</returns>
        public static DailyDate Init(DayOfMonth dayOfMonth) => new DailyDate(dayOfMonth);

        /// <summary>
        /// Sets the month of the date.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <returns>An instance of <see cref="MonthlyDate"/> with the specified month and current day of the month.</returns>
        public MonthlyDate InMonth(Months month) => MonthlyDate.Init(month, DayOfMonth);

        /// <summary>
        /// Sets the current month of the date.
        /// </summary>
        /// <returns>An instance of <see cref="MonthlyDate"/> with the current month and current day of the month.</returns>
        public MonthlyDate InCurrentMonth() => MonthlyDate.Init((Months)DateTime.Now.Month, DayOfMonth);
    }
}
