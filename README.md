<p align="center">
    <a href="https://www.nuget.org/packages/hmdmhmd.TimeMachine" target="blank"><img src="https://github.com/mhmdhmd/TimeMachine/blob/master/TimeMachine/icon.png" width="64" alt="TimeMachine Logo" /></a>
    <h1 align="center">TimeMachine</h1>
</p>

<p align="center">
<img alt="Version" src="https://img.shields.io/nuget/v/hmdmhmd.TimeMachine"/>
<img alt="Download" src="https://img.shields.io/nuget/dt/hmdmhmd.TimeMachine"/>
<img alt="Static Badge" src="https://img.shields.io/badge/license-MIT-orange"/>
</p>

**TimeMachine** is a library for generating `DateTime` objects fluently in a highly readable and descriptive manner. It simplifies the creation of `DateTime` instances, enhancing code clarity and maintainability. This library is perfect for all programming scenarios, especially unit tests where readability is crucial.

- [Nuget Package](https://www.nuget.org/packages/hmdmhmd.TimeMachine)

## Features

- **Fluent and Descriptive**: Generate `DateTime` objects using a fluent interface that reads like natural language.
- **Readable and Maintainable**: Improves code readability and maintainability, making it easier to understand and modify.
- **Versatile**: Suitable for all programming parts, particularly useful in unit tests.

> **_NOTE:_** the version `1.0.1` does not support `Time` components (hours, minutes, seconds) **yet**

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
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

- Fork the repository
- Create a feature branch (`git checkout -b feature-branch`)
- Commit your changes (`git commit -am 'Add new feature'`)
- Push to the branch (`git push origin feature-branch`)
- Create a new Pull Request

Please make sure to update tests as appropriate.
