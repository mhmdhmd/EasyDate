﻿using System;

namespace TimeMachine.Exceptions
{
    public class InvalidYearException : Exception
    {
        public InvalidYearException(int year)
            : base($"The year {year} is out of the valid range (1-9999).") { }
    }
}