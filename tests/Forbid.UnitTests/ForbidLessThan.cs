using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidLessThan
{
    [Fact]
    public void LessThen_ThrowWhenLessThanSomething()
    {
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.LessThan(1, 2));
    }

    [Fact]
    public void LessThen_NotThrowWhenMoreThanSomething()
    {
        Forbids.Forbid.From.LessThan(2, 1);
        Forbids.Forbid.From.LessThan(2, 1);
    }
}