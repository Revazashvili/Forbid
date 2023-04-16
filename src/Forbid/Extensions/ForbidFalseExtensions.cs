namespace Forbids;

/// <summary>
/// A collection of False forbid methods as extension methods.
/// </summary>
public static class ForbidFalseExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool False(this IForbid forbid, bool input) => False(input);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool False(this IForbid forbid, bool input, string message) => False(input, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is false.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool False(this IForbid forbid, bool input, Exception exception) => False(input, null, exception);

    /// <summary>
    ///  Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> False(this IForbid forbid, params bool[] inputArray) => inputArray.ForEach(forbid.False);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> False(this IForbid forbid, string message, params bool[] inputArray) => inputArray.ForEach(input => forbid.False(input, message));

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> False(this IForbid forbid, Exception exception, params bool[] inputArray) => inputArray.ForEach(input => forbid.False(input, exception));

    /// <summary>
    /// Check input and throws <see cref="Exception"/> if it's false.
    /// </summary>
    /// <param name="input"><see cref="Boolean"/> value to check.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <returns><see cref="bool"/> value.</returns>
    private static bool False(bool input, string? message = null, Exception? exception = null)
    {
        Forbid.From.Null(input);
        if (!input)
            ForbidThrower.ThrowWithPriority(nameof(input), message, exception);
        return input;
    }
}
