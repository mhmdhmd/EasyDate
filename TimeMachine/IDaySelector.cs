namespace TimeMachine
{
    /// <summary>
    /// Interface for selecting a day of the month.
    /// </summary>
    /// <typeparam name="T">The type of the implementing class.</typeparam>
    internal interface IDaySelector<out T>
    {
        /// <summary>
        /// Sets the day of the month.
        /// </summary>
        /// <param name="dayOfMonth">The day of the month.</param>
        /// <returns>An instance of the implementing class with the specified day of the month.</returns>
        T OnDay(DayOfMonth dayOfMonth);
    }
}
