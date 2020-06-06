using System;
using NUnit.Framework;

namespace ChristmasTests
{
    public class ChristmasTests
    {
        private readonly FakeHoliday _fakeHoliday = new FakeHoliday();

        [Test]
        public void Today_Is_Xmas()
        {
            GivenToday(12, 25);
            SayXmasShouldResponse("Merry X'mas");
        }

        [Test]
        public void Today_Is_Xmas_night()
        {
            GivenToday(12, 24);
            SayXmasShouldResponse("Merry X'mas");
        }

        [Test]
        public void Today_Is_Not_Xmas()
        {
            GivenToday(10, 25);
            SayXmasShouldResponse("Today is not X'mas");
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