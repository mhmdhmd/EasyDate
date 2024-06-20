using System;

namespace EasyDate
{
    public class DaySteps : TimeSteps
    {
        public DaySteps(int day) : base(day) { }
        public override DateTime After(DateTime dateTime) =>
            dateTime.AddDays(Value);
        public override DateTime Before(DateTime dateTime) =>
            dateTime.AddDays(-Value);
    }
}