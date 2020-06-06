using System;

namespace ChristmasTests
{
    public class ChristmasTests
    {
    }

    public class Holiday
    {
        public void SayHello()
        {
            if (DateTime.Today.Month == 12 && DateTime.Today.Day == 25)
            {
                Console.WriteLine("Merry Christmas");
            }
            else
            {
                Console.WriteLine("Today is not Christmas");
            }
        }
    }
}