using System;

namespace TimeMachine
{
    /// <summary>
    /// Represents a date with a specified month and day of the month.
    /// </summary>
    public class MonthlyDate : IDateTimeBuilder, IDaySelector<MonthlyDate>
    {
        private const int MinYear = 1;
        private const int MaxYear = 9999;

        /// <summary>
        /// Gets the month of the year.
        /// </summary>
        public Months MonthOfYear { get; }

        /// <summary>
        /// Gets the day of the month.
        /// </summary>
        public DayOfMonth DayOfMonth { get; private set; }

        /// <summary>
        /// Gets the year.
        /// </summary>
        public int Year { get; private set; }

        private MonthlyDate(Months monthOfYear, DayOfMonth dayOfMonth)
        {
            MonthOfYear = monthOfYear;
            DayOfMonth = dayOfMonth;
            Year = DateTime.Now.Year;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyDate"/> class with the specified month and day of the month.
        /// </summary>
        /// <param name="months">The month.</param>
        /// <param name="dayOfMonth">The day of the month.</param>
        /// <returns>A new instance of the <see cref="MonthlyDate"/> class.</returns>
        public static MonthlyDate Init(Months months, DayOfMonth dayOfMonth) => new MonthlyDate(months, dayOfMonth);

        /// <summary>
        /// Sets the day of the month.
        /// </summary>
        /// <param name="dayOfMonth">The day of the month.</param>
        /// <returns>An instance of <see cref="MonthlyDate"/> with the specified day of the month.</returns>
        public MonthlyDate OnDay(DayOfMonth dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
            return this;
        }

        /// <summary>
        /// Sets the year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>An instance of <see cref="MonthlyDate"/> with the specified year.</returns>
        /// <exception cref="InvalidYearException">Thrown when the year is out of the valid range (1-9999).</exception>
        public MonthlyDate AtYear(int year)
        {
            if (year < MinYear || year > MaxYear)
                throw new InvalidYearException(year);

            Year = year;
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
