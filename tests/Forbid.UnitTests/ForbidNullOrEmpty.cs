using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidNullOrEmpty
    {
        [Fact]
        public void ThrowWhenNullNotEmpty()
        {
            string? nullString = null;
            Assert.Throws<ArgumentNullException>(() => Forbids.Forbid.From.NullOrEmpty(nullString));
        }
        
        [Fact]
        public void ThrowWhenEmptyNotNull()
        {
            string empty = string.Empty;
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NullOrEmpty(empty));
        }

        [Fact]
        public void ReturnsPassedValue()
        {
            Assert.Equal("string", Forbids.Forbid.From.NullOrEmpty("string"));
        }
    }
}