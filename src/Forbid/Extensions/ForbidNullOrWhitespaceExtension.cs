namespace Forbids;

/// <summary>
/// A collection of NullOrWhitespace forbid methods as extension methods.
/// </summary>
public static class ForbidNullOrWhitespaceExtension
{
    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty or whitespace string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <returns><see cref="IEnumerable{T}"/> input.</returns>
    /// <exception cref="ArgumentException"><see cref="Exception"/> which will be thrown if input is null or whitespace.</exception>
    public static string NullOrWhitespace(this IForbid forbid, string? input)
    {
        Forbid.From.NullOrEmpty(input);
        if (IsNullOrWhiteSpace(input))
            throw new ArgumentException(null, nameof(input));
        return input!;
    }

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty or whitespace string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <returns><see cref="string"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null or whitespace.</exception>
    public static string NullOrWhitespace(this IForbid forbid, string? input, string? message)
    {
        Forbid.From.NullOrEmpty(input,message);
        if (IsNullOrWhiteSpace(input))
            Thrower.ThrowIfNotNull(message, nameof(input));
        return input!;
    }

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty or whitespace string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown.</param>
    /// <returns><see cref="string"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null or whitespace.</exception>
    public static string NullOrWhitespace(this IForbid forbid, string? input, Exception? exception)
    {
        Forbid.From.NullOrEmpty(input,exception);
        if (IsNullOrWhiteSpace(input))
            Thrower.ThrowIfNotNull(exception, nameof(input));
        return input!;
    }
}
