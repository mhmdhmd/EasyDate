using System;

namespace TimeMachine
{
    public class MonthSteps : TimeSteps
    {
        public MonthSteps(int month) : base(month) { }
        public override DateTime After(DateTime dateTime) =>
            dateTime.AddMonths(Value);
        public override DateTime Before(DateTime dateTime) =>
            dateTime.AddMonths(-Value);
    }
}