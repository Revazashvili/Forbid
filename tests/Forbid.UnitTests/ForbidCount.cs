using System;
using System.Collections.Generic;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidCount
{
    [Fact]
    public void Count_ThrowWhenCountEqualsPassedCount()
    {
        IEnumerable<int> list = new List<int> { 1, 2, 3 };
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Count(list,3));
    }
        
    [Fact]
    public void Count_NotThrowWhenCountNotEqualsPassedCount()
    {
        IEnumerable<int> list = new List<int> { 1, 2, 3 };
        Forbids.Forbid.From.Count(list, 4);
    }

    [Fact]
    public void Count_ThrowCustomExceptionWhenCountEqualsPassedCount()
    {
        IEnumerable<int> list = new List<int> { 1, 2, 3 };
        var countException = new ForbidCountException("Count should not be 3.");
        Assert.Throws<ForbidCountException>(() => Forbids.Forbid.From.Count(list,3,countException));
    }

    private class ForbidCountException : Exception
    {
        public ForbidCountException(string message) : base(message) { }
    }
}