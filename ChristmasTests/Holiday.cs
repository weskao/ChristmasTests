using System;

namespace ChristmasTests
{
    public class Holiday
    {
        public string SayHello()
        {
            if (GetToday().Month == 12 &&
                (GetToday().Day == 24 || GetToday().Day == 25))
            {
                return "Merry X'mas";
            }
            else
            {
                return "Today is not X'mas";
            }
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}