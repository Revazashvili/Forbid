using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidNotEqual
{
    [Fact]
    public void NotEqual_ThrowsExceptionWhenEqual() =>
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NotEqual(100, 10));

    [Fact]
    public void NotEqual_NotThrowsExceptionWhenEqual() => Forbids.Forbid.From.NotEqual(10, 10);

}