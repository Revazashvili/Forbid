using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidNullOrEmpty
{
    [Fact]
    public void ThrowWhenNullNotEmpty()
    {
        string? nullString = null;
        string? nullString2 = null;
        Assert.Throws<ArgumentNullException>(() => Forbids.Forbid.From.NullOrEmpty(nullString));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NullOrEmpty(nullString,nullString2));

        Guid? nullGuid = null;
        Assert.Throws<ArgumentNullException>(() => Forbids.Forbid.From.NullOrEmpty(nullGuid));
    }

    [Fact]
    public void ThrowWhenEmptyNotNull()
    {
        string empty = string.Empty;
        string empty2 = string.Empty;
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NullOrEmpty(empty));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NullOrEmpty(empty, empty2));
    }
        
    [Fact]
    public void NotThrowExceptionWhenNotNull()
    {
        Forbids.Forbid.From.NullOrEmpty("input");
        Forbids.Forbid.From.NullOrEmpty("input","input2","input3");
    }

    [Fact]
    public void ReturnsPassedValue()
    {
        Assert.Equal("string", Forbids.Forbid.From.NullOrEmpty("string"));
    }
}