# TimeMachine

**TimeMachine** is a library for generating `DateTime` objects fluently in a highly readable and descriptive manner. It simplifies the creation of `DateTime` instances, enhancing code clarity and maintainability. This library is perfect for all programming scenarios, especially unit tests where readability is crucial.

## Features

- **Fluent and Descriptive**: Generate `DateTime` objects using a fluent interface that reads like natural language.
- **Readable and Maintainable**: Improves code readability and maintainability, making it easier to understand and modify.
- **Versatile**: Suitable for all parts of programming, particularly useful in unit tests.

## Example Usage

Here's an example of how to use the **TimeMachine**:

```csharp
using TimeMachine;

var myBirthDay = GoTo
    .Month(Months.Aug)
    .OnDay(DayOfMonth.TwentyFourth)
    .AtYear(1985)
    .LetsGo();

Console.WriteLine(myBirthDay); // 8/24/1985 12:00:00 AM

var today = GoTo.Today();
Console.WriteLine($"Today's date is: {today}"); // Today's date is: 6/8/2024 1:03:28 AM

var lastDayOfJanuary = GoTo
    .LastDay()
    .InMonth(Months.Jan)
    .AtYear(2024)
    .LetsGo();

Console.WriteLine($"Last day of Jan is: {lastDayOfJanuary}"); // Last day of Jan is: 1/31/2024 12:00:00 AM
