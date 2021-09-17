using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidNullOrWhitespace
    {
        [Fact]
        public void ThrowsWhenNull()
        {
            string? nullString = null;
            Assert.Throws<ArgumentNullException>(() => Forbids.Forbid.From.NullOrWhitespace(nullString));
        }
        
        [Fact]
        public void ThrowsWhenWhitespace()
        {
            string nullString = "  ";
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NullOrWhitespace(nullString));
        }

        [Fact]
        public void ReturnsPassedValue()
        {
            Assert.Equal("s", Forbids.Forbid.From.NullOrWhitespace("s"));
        }
    }
}