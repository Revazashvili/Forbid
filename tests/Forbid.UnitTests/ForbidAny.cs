using System;
using System.Collections.Generic;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidAny
{
    [Fact]
    public void Any_ThrowWhenAnyElementSatisfiesCondition()
    {
        IEnumerable<int> integerList = new List<int> { 1, 2, 3 };
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Any(integerList, x => x % 2 == 0));
    }
        
    [Fact]
    public void Any_NotThrowWhenNotASingleElementSatisfiesCondition()
    {
        IEnumerable<int> integerList = new List<int> { 1, 2, 3 };
        Forbids.Forbid.From.Any(integerList, x => x > 4);
    }
    
    [Fact]
    public void Any_ThrowCustomMessageWhenAnyElementSatisfiesCondition()
    {
        const string message = "number can't be even.";
        IEnumerable<int> integerList = new List<int> { 1, 2, 3 };
        var argumentException = Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Any(integerList, x => x % 2 == 0,message));
        Assert.Equal(message, argumentException.Message);
    }
    
    [Fact]
    public void Any_ThrowCustomExceptionWhenAnyElementSatisfiesCondition()
    {
        IEnumerable<int> integerList = new List<int> { 1, 2, 3 };
        var anyException = new ForbidAnyException();
        Assert.Throws<ForbidAnyException>(() => Forbids.Forbid.From.Any(integerList, x => x % 2 == 0,anyException));
    }

    private class ForbidAnyException : Exception
    {
        public ForbidAnyException() : base("number can't be even.") {}
    }
}