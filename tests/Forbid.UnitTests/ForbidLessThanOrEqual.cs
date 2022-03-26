using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidLessThanOrEqual
    {
        [Fact]
        public void LessThanOrEqual_ThrowWhenLessSomethingOrEqual()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.LessThanOrEqual(1, 2));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.LessThanOrEqual(2, 2));
        }

        [Fact]
        public void LessThanOrEqual_NotThrowWhenMoreThanSomething()
        {
            Forbids.Forbid.From.LessThanOrEqual(2, 1);
            Forbids.Forbid.From.LessThanOrEqual(2, 1);
        }
    }
}