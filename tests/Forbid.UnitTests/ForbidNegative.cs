using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidNegative
{
    [Fact]
    public void Negative_ThrowWhenNegative()
    {
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Negative(-1));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Negative(-1.2));
    }

    [Fact]
    public void Negative_NotThrowWhenPositive()
    {
        Forbids.Forbid.From.Negative(1);
        Forbids.Forbid.From.Negative(DateTime.MaxValue);
        Forbids.Forbid.From.Negative(123.123);
    }
}