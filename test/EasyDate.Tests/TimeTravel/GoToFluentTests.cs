using FluentAssertions;

namespace EasyDate.Tests.TimeTravel
{
    public class GoToFluentTests
    {
        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForSpecificDayAndMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(2024, 5, 15).At(now.Hour, now.Minute, now.Second);

            // Act
            var dateTime = GoTo.Day(Day.Fifteenth).InMonth(Month.May).At(now).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForCurrentMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(now.Year, now.Month, 10).At(now.Hour, now.Minute, now.Second);

            // Act
            var dateTime = GoTo.Day(Day.Tenth).InCurrentMonth().At(now).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForSpecificDayMonthAndYear()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(2023, 11, 5).At(now.Hour, now.Minute, now.Second);

            // Act
            var dateTime = GoTo.Year(2023).InMonth(Month.November).OnDay(Day.Fifth).At(now).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForLastDayOfMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(2024, 2, 29).At(now.Hour, now.Minute, now.Second); // Leap year

            // Act
            var dateTime = GoTo.Year(2024).InMonth(Month.February).OnDay(Day.TwentyNinth).At(now).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForFirstDayOfMonthInSpecifiedYear()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(2022, 3, 1).At(now.Hour, now.Minute, now.Second);

            // Act
            var dateTime = GoTo.Year(2022).InMonth(Month.March).OnDay(Day.First).At(now).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForCurrentDayInSpecifiedYearAndMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(2024, now.Month, now.Day).At(now.Hour, now.Minute, now.Second);

            // Act
            var dateTime = GoTo.Year(2024).InMonth((Month)now.Month).OnDay((Day)now.Day).At(now).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForToday()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(now.Year, now.Month, now.Day);

            // Act
            var dateTime = GoTo.Today().LetsGo();

            // Assert
            dateTime.Day.Should().Be(expectedDate.Day);
            dateTime.Month.Should().Be(expectedDate.Month);
            dateTime.Year.Should().Be(expectedDate.Year);
        }
        
        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForYesterday()
        {
            // Arrange
            var now = DateTime.Now.AddDays(-1);
            var expectedDate = new DateTime(now.Year, now.Month, now.Day);

            // Act
            var dateTime = GoTo.Yesterday().LetsGo();

            // Assert
            dateTime.Day.Should().Be(expectedDate.Day);
            dateTime.Month.Should().Be(expectedDate.Month);
            dateTime.Year.Should().Be(expectedDate.Year);
        }
        
        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForTomorrow()
        {
            // Arrange
            var now = DateTime.Now.AddDays(1);
            var expectedDate = new DateTime(now.Year, now.Month, now.Day);

            // Act
            var dateTime = GoTo.Tomorrow().LetsGo();

            // Assert
            dateTime.Day.Should().Be(expectedDate.Day);
            dateTime.Month.Should().Be(expectedDate.Month);
            dateTime.Year.Should().Be(expectedDate.Year);
        }
    }
}
