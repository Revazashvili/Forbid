using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests;

public class ForbidNullOrWhitespace
{
    [Fact]
    public void ThrowsWhenNull()
    {
        string? nullString = null;
        Assert.Throws<ArgumentNullException>(() => Forbids.Forbid.From.NullOrWhitespace(nullString));
    }
        
    [Fact]
    public void ThrowsWhenWhitespace()
    {
        const string whiteSpace = "  ";
        Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NullOrWhitespace(whiteSpace));
    }
        
    [Fact]
    public void NotThrowExceptionWhenNotNull()
    {
        const string input = "input";
        var output = Forbids.Forbid.From.NullOrWhitespace(input);
        Assert.Equal(input, output);
    }

    [Fact]
    public void ReturnsPassedValue()
    {
        const string input = "s";
        var output = Forbids.Forbid.From.NullOrWhitespace(input);
        Assert.Equal(input, output);
    }
    
    [Fact]
    public void ThrowsCustomMessageWhenNull()
    {
        string? nullString = null;
        const string message = "input can't be whitespace";
        var argumentException = Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NullOrWhitespace(nullString,message));
        Assert.Equal(message, argumentException.Message);
    }
    
    [Fact]
    public void ThrowsCustomMessageWhenWhitespace()
    {
        const string whiteSpace = "  ";
        const string message = "input can't be whitespace";
        var argumentException = Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NullOrWhitespace(whiteSpace,message));
        Assert.Equal(message, argumentException.Message);
    }

    [Fact]
    public void ThrowsCustomExceptionWhenNull()
    {
        string? nullString = null;
        var whitespaceException = new ForbidWhitespaceException();
        Assert.Throws<ForbidWhitespaceException>(() => Forbids.Forbid.From.NullOrWhitespace(nullString,whitespaceException));
    }
    
    [Fact]
    public void ThrowsCustomExceptionWhenWhitespace()
    {
        const string whiteSpace = "  ";
        var whitespaceException = new ForbidWhitespaceException();
        Assert.Throws<ForbidWhitespaceException>(() => Forbids.Forbid.From.NullOrWhitespace(whiteSpace,whitespaceException));
    }

    private class ForbidWhitespaceException : Exception
    {
        public ForbidWhitespaceException() : base("input can't be whitespace") { }
    }
}