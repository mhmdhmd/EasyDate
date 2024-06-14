using TimeMachine;

var myBirthDay = GoTo
    .Month(Month.August)
    .OnDay(Day.TwentyFourth)
    .AtYear(1985)
    .At(22,30,56)
    .LetsGo();

Console.WriteLine(myBirthDay); // 8/24/1985 10:30:56 PM

var today = GoTo.Today().LetsGo();
Console.WriteLine($"Today's date is: {today}"); // DateTime.Now.Hour;

var lastDayOfJanuary = GoTo
    .LastDay()
    .InMonth(Month.January)
    .AtYear(2024)
    .At(10)
    .LetsGo();

Console.WriteLine($"Last day of Jan is: {lastDayOfJanuary}"); // Last day of Jan is: 1/31/2024 10:00:00 AM
