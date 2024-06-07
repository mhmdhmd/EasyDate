using System;
using System.Collections.Generic;
using System.Text;
using TimeMachine.Enums;
using TimeMachine.Exceptions;

namespace TimeMachine
{
    /// <summary>
    /// Represents a date with a specified year, month, and day of the month.
    /// </summary>
    public class YearlyDate : IDateTimeBuilder, IDaySelector<YearlyDate>
    {
        private const int MinYear = 1;
        private const int MaxYear = 9999;

        /// <summary>
        /// Gets the month of the year.
        /// </summary>
        public Months MonthOfYear { get; private set; }

        /// <summary>
        /// Gets the day of the month.
        /// </summary>
        public DayOfMonth DayOfMonth { get; private set; }

        /// <summary>
        /// Gets the year.
        /// </summary>
        public int Year { get; }

        private YearlyDate(int year)
        {
            if (year < MinYear || year > MaxYear)
                throw new InvalidYearException(year);
            
            Year = year;
            MonthOfYear = Months.Jan;
            DayOfMonth = DayOfMonth.First;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearlyDate"/> class with the specified year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>A new instance of the <see cref="YearlyDate"/> class.</returns>
        /// <exception cref="InvalidYearException">Thrown when the year is out of the valid range (1-9999).</exception>
        public static YearlyDate Init(int year) => new YearlyDate(year);

        /// <summary>
        /// Sets the day of the month.
        /// </summary>
        /// <param name="dayOfMonth">The day of the month.</param>
        /// <returns>An instance of <see cref="YearlyDate"/> with the specified day of the month.</returns>
        public YearlyDate OnDay(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
            return this;
        }

        /// <summary>
        /// Sets the month of the year.
        /// </summary>
        /// <param name="month">The month of the year.</param>
        /// <returns>An instance of <see cref="YearlyDate"/> with the specified month of the year.</returns>
        public YearlyDate InMonth(Months month)
        {
            MonthOfYear = month;
            return this;
        }

        /// <summary>
        /// Builds the <see cref="DateTime"/> object.
        /// </summary>
        /// <returns>A <see cref="DateTime"/> object representing the specified date.</returns>
        public DateTime LetsGo()
        {
            var day = DayOfMonth == DayOfMonth.Last
                ? DateTime.DaysInMonth(Year, (int)MonthOfYear)
                : (int)DayOfMonth;
            return new DateTime(Year, (int)MonthOfYear, day);
        }
    }
}
