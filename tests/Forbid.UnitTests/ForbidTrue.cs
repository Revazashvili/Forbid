using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidTrue
    {
        [Fact]
        public void ThrowWhenTrue()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.True(true));
        }
        
        [Fact]
        public void NotThrowWhenTrue()
        {
            Forbids.Forbid.From.True(false);
        }

        [Fact]
        public void ReturnTrueWhenFalseIsPassed()
        {
            Assert.False(Forbids.Forbid.From.True(false));
        }
    }
}