namespace Forbids;

public static class ForbidLengthExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> length is equal to passed length.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The string to check length.</param>
    /// <param name="length">The length to be checked.</param>
    /// <returns>The passed input.</returns>
    public static string Length(this IForbid forbid, string input, int length) => Length(input, length);
    
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> length is equal to passed length.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The string to check length.</param>
    /// <param name="message">The message used to throw exception.</param>
    /// <param name="length">The length to be checked.</param>
    /// <returns>The passed input.</returns>
    public static string Length(this IForbid forbid, string input, int length,string message) => Length(input, length,message);
    
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> length is equal to passed length.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The string to check length.</param>
    /// <param name="exception">The exception to throw.</param>
    /// <param name="length">The length to be checked.</param>
    /// <returns>The passed input.</returns>
    public static string Length(this IForbid forbid, string input, int length,Exception exception) => Length(input, length,exception:exception);
    
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> length is equal to passed length.
    /// </summary>
    /// <param name="input">The string to check length.</param>
    /// <param name="message">The message used to throw exception.</param>
    /// <param name="exception">The exception to throw.</param>
    /// <param name="length">The length to be checked.</param>
    /// <returns>The passed input.</returns>
    private static string Length(string input,int length, string? message = null, Exception? exception = null)
    {
        Forbid.From.NullOrEmpty(input);
        var inputLength = input.Length;
        if(inputLength == length)
            Thrower.ThrowWithPriority(nameof(input),message,exception);
        return input;
    }
}