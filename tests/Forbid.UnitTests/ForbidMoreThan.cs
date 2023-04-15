using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidMoreThan
{
    [Fact]
    public void MoreThan_ThrowWhenMoreThanSomething()
    {
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.MoreThan(3, 2));
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.MoreThan(30, 20));
    }

    [Fact]
    public void MoreThan_NotThrowWhenLessThanSomething()
    {
        Forbids.Forbid.From.MoreThan(2, 5);
    }
}