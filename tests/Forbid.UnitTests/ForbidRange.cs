using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidRange
{
    [Fact]
    public void Range_ThrowWhenInRange()
    {
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Range(10, 9, 11));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Range(1, 0, 2));
    }

    [Fact]
    public void Range_NotThrowWhenOutOfRange()
    {
        Forbids.Forbid.From.Range(1, 2, 3);
        Forbids.Forbid.From.Range(0, 22, 39);
    }
}