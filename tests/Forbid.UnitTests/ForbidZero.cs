using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidZero
    {
        [Fact]
        public void Equal_ThrowsExceptionWhenEqual()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Equal(10, 10));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Equal(1.2, 1.2));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Equal(189371293, 189371293));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Equal(TimeSpan.FromMinutes(20),TimeSpan.FromMinutes(20)));
        }
        
        [Fact]
        public void Equal_NotThrowsExceptionWhenNotEqual()
        {
            Forbids.Forbid.From.Equal(10, 2);
            Forbids.Forbid.From.Equal(1.2, 2);
            Forbids.Forbid.From.Equal(1131029380, 76);
        }
    }
}