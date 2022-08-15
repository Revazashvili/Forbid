using System;
using System.Collections.Generic;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidCount
    {
        [Fact]
        public void Count_ThrowWhenCountEqualsPassedCount()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 3 };
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Count(list,3));
        }
        
        [Fact]
        public void Count_NotThrowWhenCountEqualsPassedCount()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 3 };
            Forbids.Forbid.From.Count(list, 4);
        }

        [Fact]
        public void Count_ThrowCustomExceptionWhenCountEqualsPassedCount()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 3 };
            var countException = new CountException("Count should not be 3.");
            Assert.Throws<CountException>(() => Forbids.Forbid.From.Count(list,3,countException));
        }
    }

    public class CountException : Exception
    {
        public CountException(string message) : base(message) { }
    }
}