using System;

namespace TimeMachine
{
    /// <summary>
    /// Provides static methods to create instances of DailyDate, MonthlyDate, and YearlyDate, 
    /// as well as to get the current date.
    /// </summary>
    public class GoTo
    {
        #region DailyDate
        /// <summary>
        /// Gets the first day of the month.
        /// </summary>
        /// <returns>An instance of <see cref="DailyDate"/> representing the first day of the month.</returns>
        public static DailyDate FirstDay() => DailyDate.Init(DayOfMonth.First);

        /// <summary>
        /// Gets the last day of the month.
        /// </summary>
        /// <returns>An instance of <see cref="DailyDate"/> representing the last day of the month.</returns>
        public static DailyDate LastDay() => DailyDate.Init(DayOfMonth.Last);

        /// <summary>
        /// Gets the specified day of the month.
        /// </summary>
        /// <param name="dayOfMonth">The day of the month.</param>
        /// <returns>An instance of <see cref="DailyDate"/> representing the specified day of the month.</returns>
        public static DailyDate Day(DayOfMonth dayOfMonth) => DailyDate.Init(dayOfMonth);

        /// <summary>
        /// Gets the current date.
        /// </summary>
        /// <returns>A <see cref="DateTime"/> representing the current date.</returns>
        public static DateTime Today() => DateTime.Now;
        #endregion

        #region MonthlyDate
        /// <summary>
        /// Gets the first month of the year with the first day.
        /// </summary>
        /// <returns>An instance of <see cref="MonthlyDate"/> representing the first month of the year with the first day.</returns>
        public static MonthlyDate FirstMonth() => MonthlyDate.Init(Months.Jan, DayOfMonth.First);

        /// <summary>
        /// Gets the last month of the year with the first day.
        /// </summary>
        /// <returns>An instance of <see cref="MonthlyDate"/> representing the last month of the year with the first day.</returns>
        public static MonthlyDate LastMonth() => MonthlyDate.Init(Months.Dec, DayOfMonth.First);

        /// <summary>
        /// Gets the specified month of the year with the first day.
        /// </summary>
        /// <param name="months">The month of the year.</param>
        /// <returns>An instance of <see cref="MonthlyDate"/> representing the specified month of the year with the first day.</returns>
        public static MonthlyDate Month(Months months) => MonthlyDate.Init(months, DayOfMonth.First);
        #endregion

        #region YearlyDate
        /// <summary>
        /// Gets the specified year with the first month and first day.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>An instance of <see cref="YearlyDate"/> representing the specified year with the first month and first day.</returns>
        /// <exception cref="InvalidYearException">Thrown when the year is out of the valid range (1-9999).</exception>
        public static YearlyDate Year(int year) => YearlyDate.Init(year);
        #endregion
    }
}
