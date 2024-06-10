using System;

namespace TimeMachine
{
    public class WeekSteps : TimeSteps
    {
        public WeekSteps(int week) : base(week) { }
        public override DateTime After(DateTime dateTime) =>
            dateTime.AddDays(Value * 7);
        public override DateTime Before(DateTime dateTime) =>
            dateTime.AddDays(-(Value * 7));
    }
}