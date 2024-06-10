# TimeMachine

**TimeMachine** is a library for generating `DateTime` objects fluently in a highly readable and descriptive manner. It simplifies the creation of `DateTime` instances, enhancing code clarity and maintainability. This library is perfect for all programming scenarios, especially unit tests where readability is crucial.

- [Github Repo](https://github.com/mhmdhmd/TimeMachine)

## Features

- **Fluent and Descriptive**: Generate `DateTime` objects using a fluent interface that reads like natural language.
- **Readable and Maintainable**: Improves code readability and maintainability, making it easier to understand and modify.
- **Versatile**: Suitable for all programming parts, particularly useful in unit tests.

> **_NOTE:_** the version `2.1.0` does not support `Time` components (hours, minutes, seconds) **yet**

## Example Usage

Here's an example of how to use the **TimeMachine**:

```csharp
using TimeMachine;

var myBirthDay = GoTo
    .Month(Month.August)
    .OnDay(Day.TwentyFourth)
    .AtYear(1985)
    .LetsGo();

Console.WriteLine(myBirthDay); // 8/24/1985 12:00:00 AM

var today = GoTo.Today().LetsGo();
Console.WriteLine($"Today's date is: {today}"); // Today's date is: 6/8/2024 1:03:28 AM

var lastDayOfJanuary = GoTo
    .LastDay()
    .InMonth(Month.January)
    .AtYear(2024)
    .LetsGo();

Console.WriteLine($"Last day of Jan is: {lastDayOfJanuary}"); // Last day of Jan is: 1/31/2024 12:00:00 AM
```
```csharp
using TimeMachine;

8.August(1985);                     // 8/8/1985
4.Days().Before(DateTime.Now);      // 6/6/2024
2.Weeks().After(DateTime.Now);      // 6/24/2024
10.Months().Before(DateTime.Now);   // 8/10/2023
6.Weeks().Later();                  // 7/22/2024
2.Years().Ago();                    // 6/10/2022
```
