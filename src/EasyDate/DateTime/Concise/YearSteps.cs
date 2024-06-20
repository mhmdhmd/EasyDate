using System;

namespace EasyDate
{
    public class YearSteps : TimeSteps
    {
        public YearSteps(int year) : base(year) { }
        public override DateTime After(DateTime dateTime) =>
            dateTime.AddYears(Value);
        public override DateTime Before(DateTime dateTime) =>
            dateTime.AddYears(-Value);
    }
}