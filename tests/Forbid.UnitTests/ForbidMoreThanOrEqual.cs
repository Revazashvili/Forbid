using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidMoreThanOrEqual
{
    [Fact]
    public void MoreThanOrEqual_ThrowWhenMoreThanSomethingOrEqual()
    {
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.MoreThanOrEqual(10, 2));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.MoreThanOrEqual(10, 10));
    }

    [Fact]
    public void MoreThanOrEqual_NotThrowWhenLessThanSomething()
    {
        Forbids.Forbid.From.MoreThanOrEqual(10, 20);
    }
}