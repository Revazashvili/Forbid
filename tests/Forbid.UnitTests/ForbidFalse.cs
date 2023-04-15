using System;
using System.Linq;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidFalse
{
    [Fact]
    public void False_ThrowWhenFalse()
    {
        var equal = 2 == 3;
            
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.False(false));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.False(equal));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.False(equal,false));
    }

    [Fact]
    public void False_NotThrowWhenTrue()
    {
        var equal = 22 == 22; 
        Forbids.Forbid.From.False(equal);
        Forbids.Forbid.From.False(true);
        Forbids.Forbid.From.False(true,equal);
        var result = Forbids.Forbid.From.False(true,equal);
        Assert.Equal(2, result.Count());
    }
}