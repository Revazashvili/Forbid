using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidNegativeOrZero
    {
        [Fact]
        public void NegativeOrZero_ThrowWhenZeroOrNegative()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NegativeOrZero(0));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NegativeOrZero(-1));
        }

        [Fact]
        public void NegativeOrZero_NotThrowWhenPositiveBesideZero()
        {
            Forbids.Forbid.From.NegativeOrZero(1);
            Forbids.Forbid.From.NegativeOrZero(18937129);
        }
    }
}