using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidLength
    {
        [Fact]
        public void Length_ThrowWhenInputLengthEqualsPassedLength()
        {
            var input = "test";
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Length(input, 4));
        }
        
        [Fact]
        public void Length_NotThrowWhenInputLengthNotEqualsPassedLength()
        {
            var input = "test";
            Forbids.Forbid.From.Length(input, 3);
        }
        
        [Fact]
        public void Length_ThrowCustomExceptionWhenInputLengthEqualsPassedLength()
        {
            var input = "test";
            var lengthException = new LengthException("Length should not be 4.");
            Assert.Throws<LengthException>(() => Forbids.Forbid.From.Length(input, 4,lengthException));
        }
    }
    
    public class LengthException : Exception
    {
        public LengthException(string message) :base(message){}
    }
}