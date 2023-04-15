using System;
using System.Linq;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidTrue
{
    [Fact]
    public void True_ThrowWhenTrue()
    {
        var equal = 2 == 2;
            
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.True(true));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.True(equal));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.True(equal,true));
    }

    [Fact]
    public void True_NotThrowWhenFalse()
    {
        var equal = 2 == 3;
            
        Forbids.Forbid.From.True(false);
        Forbids.Forbid.From.True(equal);
        Forbids.Forbid.From.True(false, equal);
        var result = Forbids.Forbid.From.True(false, equal);
        Assert.Equal(2, result.Count());
    }
}