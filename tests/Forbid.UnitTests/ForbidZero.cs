using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidZero
    {
        [Fact]
        public void Zero_ThrowsWhenZero()
        {
            double zeroDouble = 0.0;
            long zeroLong = 0;
            
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Zero(zeroDouble));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Zero(zeroLong));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Zero(0));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Zero(zeroDouble,zeroLong,0));
            Assert.Throws<Exception>(() => Forbids.Forbid.From.Zero(new Exception("none of the element in  the array should be zero"),zeroDouble,zeroLong,0));
        }
        
        [Fact]
        public void Zero_NotThrowsWhenNotEqualZero()
        {
            Forbids.Forbid.From.Zero(10);
            Forbids.Forbid.From.Zero(1.2);
            Forbids.Forbid.From.Zero(11231231);
            Forbids.Forbid.From.Zero(1,2,3,4,5);
        }
    }
}