using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidPositiveOrZero
{
    [Fact]
    public void PositiveOrZero_ThrowWhenPositiveOrZero()
    {
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.PositiveOrZero(0));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.PositiveOrZero(190237));
    }

    [Fact]
    public void PositiveOrZero_NotThrowWhenNegativeBesideZero()
    {
        Forbids.Forbid.From.PositiveOrZero(-1);
        Forbids.Forbid.From.PositiveOrZero(5 - 8);
    }
}