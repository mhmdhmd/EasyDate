using System;

namespace EasyDate
{
    public interface IDate
    {
        int Year { get; }
        Month Month { get; }
        Day Day { get; }
        DateTime LetsGo();
    }
}