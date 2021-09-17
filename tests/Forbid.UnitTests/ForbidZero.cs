using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidZero
    {
        [Fact]
        public void ThrowWhenZero()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Zero(0));
        }
        
        [Fact]
        public void NotThrowWhenNotZero()
        {
            Forbids.Forbid.From.Zero(1);
        }

        [Fact]
        public void ReturnsPassedValue()
        {
            Assert.Equal(10, Forbids.Forbid.From.Zero(10));
        }
    }
}