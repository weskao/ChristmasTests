using System;
using NUnit.Framework;

namespace ChristmasTests
{
    public class ChristmasTests
    {
        [Test]
        public void Today_Is_xmas()
        {
            var holidayForTest = new HolidayForTest();
            holidayForTest.SetToday(12, 25);

            Assert.AreEqual("Merry X'mas", holidayForTest.SayHello());
        }
    }

    public class Holiday
    {
        public string SayHello()
        {
            if (GetToday().Month == 12 && GetToday().Day == 25)
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

    public class HolidayForTest : Holiday
    {
        private DateTime _today;

        protected override DateTime GetToday()
        {
            return _today;
        }

        public void SetToday(int month, int day)
        {
            _today = new DateTime(2025, month, day);
        }
    }
}