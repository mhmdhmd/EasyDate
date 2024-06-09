using System;

namespace TimeMachine
{
    public interface IDate
    {
        int Year { get; }
        MonthOfYear MonthOfYear { get; }
        DayOfMonth DayOfMonth { get; }
        DateTime LetsGo();
    }
}