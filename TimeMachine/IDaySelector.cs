using TimeMachine.Enums;

namespace TimeMachine
{
    internal interface IDaySelector<out T>
    {
        T OnDay(DayOfMonth dayOfMonth);
    }
}
