using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidPositive
    {
        [Fact]
        public void Positive_ThrowsWhenPositive()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Positive(10));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Positive(1.2));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Positive(TimeSpan.MaxValue));
        }
        
        [Fact]
        public void Positive_NotThrowsWhenNegative()
        {
            Forbids.Forbid.From.Positive(-10);
            Forbids.Forbid.From.Positive(-1.2);
        }
    }
}