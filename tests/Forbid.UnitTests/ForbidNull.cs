using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidNull
    {
        [Fact]
        public void ThrowExceptionWhenNull()
        {
            int? nullableInteger = null;
            Assert.Throws<ArgumentNullException>(() => Forbids.Forbid.From.Null(nullableInteger));
        }
        
        [Theory]
        [InlineData(10)]
        [InlineData("string")]
        [InlineData(1.2)]
        public void NotThrowExceptionWhenNotNull<T>(T input)
        {
            Forbids.Forbid.From.Null(input);
        }

        [Fact]
        public void ReturnsPassedValue()
        {
            Assert.Equal(1,Forbids.Forbid.From.Null(1));
            Assert.Equal(DateTime.Today, Forbids.Forbid.From.Null(DateTime.Today));
            Assert.Equal("string",Forbids.Forbid.From.Null("string"));

            var guid = Guid.NewGuid();
            Assert.Equal(guid,Forbids.Forbid.From.Null(guid));
        }
    }
}