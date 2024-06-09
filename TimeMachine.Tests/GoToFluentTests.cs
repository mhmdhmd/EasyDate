using FluentAssertions;

namespace TimeMachine.Tests
{
    public class GoToFluentTests
    {
        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForSpecificDayAndMonth()
        {
            // Arrange
            var expectedDate = new DateTime(2024, 5, 15);

            // Act
            var dateTime = GoTo.Day(Day.Fifteenth).InMonth(Month.May).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForCurrentMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(now.Year, now.Month, 10);

            // Act
            var dateTime = GoTo.Day(Day.Tenth).InCurrentMonth().LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForSpecificDayMonthAndYear()
        {
            // Arrange
            var expectedDate = new DateTime(2023, 11, 5);

            // Act
            var dateTime = GoTo.Year(2023).InMonth(Month.Nov).OnDay(Day.Fifth).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForLastDayOfMonth()
        {
            // Arrange
            var expectedDate = new DateTime(2024, 2, 29); // Leap year

            // Act
            var dateTime = GoTo.Year(2024).InMonth(Month.Feb).OnDay(Day.TwentyNinth).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForFirstDayOfMonthInSpecifiedYear()
        {
            // Arrange
            var expectedDate = new DateTime(2022, 3, 1);

            // Act
            var dateTime = GoTo.Year(2022).InMonth(Month.Mar).OnDay(Day.First).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForCurrentDayInSpecifiedYearAndMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(2024, now.Month, now.Day);

            // Act
            var dateTime = GoTo.Year(2024).InMonth((Month)now.Month).OnDay((Day)now.Day).LetsGo();

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
