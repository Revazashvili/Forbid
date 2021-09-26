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

        [Fact]
        public void NullWithParams_ThrowExceptionWhenAtLeastOneIsNull()
        {
            int? firstNull = null;
            int? secondNull = null;
            int? thirdNull = null;
            Assert.Throws<ArgumentNullException>(() => Forbids.Forbid.From.Null(firstNull, secondNull, thirdNull));
        }

        [Fact]
        public void NullWithParams_ThrowExceptionWhenEmptyArray()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Null(Array.Empty<int>()));
        }
        
        [Fact]
        public void NullWithParams_ThrowExceptionWhenNullArray()
        {
            int[]? nullableArray = null;
            Assert.Throws<ArgumentNullException>(() => Forbids.Forbid.From.Null(nullableArray));
        }
        
        [Fact]
        public void NullWithParams_NotThrowExceptionWhenNothingIsNull()
        {
            int[] ints = {1,2,3,4,5,6,7,8,9,10};
            Forbids.Forbid.From.Null(ints);
        }
    }
}