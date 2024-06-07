using TimeMachine;
using TimeMachine.Enums;

var myBirthday = GoTo.Year(1985).InMonth(Months.Aug).OnDay(DayOfMonth.TwentyFourth).LetsGo();

Console.WriteLine(myBirthday);