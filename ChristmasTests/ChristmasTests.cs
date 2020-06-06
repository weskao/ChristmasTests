using System;
using NUnit.Framework;

namespace ChristmasTests
{
    public class ChristmasTests
    {
        private readonly FakeHoliday _fakeHoliday = new FakeHoliday();

        [Test]
        public void Today_Is_xmas()
        {
            GivenToday(12, 25);
            SayXmasShouldResponse("Merry X'mas");
        }

        private void SayXmasShouldResponse(string merryXMas)
        {
            Assert.AreEqual(merryXMas, _fakeHoliday.SayHello());
        }

        private void GivenToday(int month, int day)
        {
            _fakeHoliday.SetToday(new DateTime(2025, month, day));
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

    public class FakeHoliday : Holiday
    {
        private DateTime _today;

        protected override DateTime GetToday()
        {
            return _today;
        }

        public void SetToday(DateTime today)
        {
            _today = today;
        }
    }
}