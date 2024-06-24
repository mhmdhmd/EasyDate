<p align="center">
    <a href="https://www.nuget.org/packages/EasyDate" target="blank"><img src="https://github.com/mhmdhmd/EasyDate/blob/master/src/EasyDate/icon.png" width="64" alt="EasyDate Logo" /></a>
    <h1 align="center">EasyDate</h1>
</p>

<p align="center">
<img alt="Version" src="https://img.shields.io/nuget/v/EasyDate"/>
<img alt="Download" src="https://img.shields.io/nuget/dt/EasyDate"/>
<img alt="Static Badge" src="https://img.shields.io/badge/license-MIT-orange"/>
</p>

**EasyDate** is a library for generating `DateTime` objects fluently in a highly readable and descriptive manner. It simplifies the creation of `DateTime` instances, enhancing code clarity and maintainability. This library is perfect for all programming scenarios, especially unit tests where readability is crucial.

- [Nuget Package](https://www.nuget.org/packages/EasyDate)

## Features

- **Fluent and Descriptive**: Generate `DateTime` objects using a fluent interface that reads like natural language.
- **Readable and Maintainable**: Improves code readability and maintainability, making it easier to understand and modify.
- **Versatile**: Suitable for all programming parts, particularly useful in unit tests.

## Example Usage

Here's an example of how to use the **EasyDate**:

```csharp
using EasyDate;

var myBirthDay = GoTo
    .Month(Month.August)
    .OnDay(Day.TwentyFourth)
    .AtYear(1985)
    .At(22,53)
    .LetsGo();

Console.WriteLine(myBirthDay); // 8/24/1985 10:53:00 PM

var today = GoTo.Today().LetsGo();
Console.WriteLine($"Today's date is: {today}"); // Today's date is: 6/14/2024 6:15:08 PM

var lastDayOfJanuary = GoTo
    .LastDay()
    .InMonth(Month.January)
    .AtYear(2024)
    .At(15,20,35)
    .LetsGo();

Console.WriteLine($"Last day of Jan is: {lastDayOfJanuary}"); // Last day of Jan is: 1/31/2024 3:20:35 PM
```
```csharp
using EasyDate;

8.August(1985).At(23,15);                       // 8/8/1985 11:15:00 PM
4.Days().Before(DateTime.Now);                  // 6/10/2024 6:20:36 PM
2.Weeks().After(DateTime.Now);                  // 6/28/2024 6:20:36 PM
10.Months().Before(DateTime.Now).At(14,30,50);  // 8/14/2023 2:30:50 PM
6.Weeks().Later();                              // 7/26/2024 6:20:36 PM
2.Years().Ago();                                // 6/14/2022 6:20:36 PM
```
```csharp
using EasyDate;

8.InMotn<April>(2024).At(15, 20).AM();      //  4/8/2024 3:20:00 AM
DateTime.Now.AM();                          //  6/24/2024 4:57:42 AM
3.Weeks().FromNow();                        //  7/15/2024 4:52:03 PM
6.OClock(DayPeriod.PM);                     //  6/24/2024 6:00:00 PM
9.OClock().AM();                            //  6/24/2024 9:00:00 AM
15.July();                                  //  7/15/2024 12:00:00 AM (current year)
13.January(2023).IsFriday();                //  is friday: True
GoTo.Month(Month.February)
    .OnDay(Day.Eleventh)
    .AtYear(1985)
    .LetsGo().IsWednesday();                //  is wednesday: False
4.December(2024).NextDay();                 //  12/5/2024 12:00:00 AM
GoTo.Day(Day.Eighth).LetsGo().NextDay();    //  6/9/2024 4:52:03 PM
23.InMotn<March>(2012).PreviousMonth();     //  2/23/2012 12:00:00 AM
GoTo.Year(2000).LetsGo().NextYear();        //  1/1/2001 4:52:03 PM
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
