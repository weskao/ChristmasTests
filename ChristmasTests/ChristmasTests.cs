using System;
using NSubstitute;
using NUnit.Framework;

namespace ChristmasTests
{
    public class Holiday
    {
        public string SayHello()
        {
            if (GetToday().Month == 12 && DateTime.Today.Day == 25)
            {
                return "Merry Christmas";
            }
            else
            {
                return "Today is not Christmas";
            }
        }

        protected DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}