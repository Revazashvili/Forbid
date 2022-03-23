using System.Linq;

namespace Forbids;

/// <summary>
/// A collection of True forbid methods as extension methods.
/// </summary>
public static class ForbidTrueExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool True(this IForbid forbid, bool input) => ForbidDefaultExtensions.True(input);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool True(this IForbid forbid, bool input, string message) => ForbidDefaultExtensions.True(input, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool True(this IForbid forbid, bool input, Exception exception) => ForbidDefaultExtensions.True(input, null, exception);

    /// <summary>
    ///  Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> True(this IForbid forbid, params bool[] inputArray) => inputArray.ForEach(forbid.True);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> True(this IForbid forbid, string message, params bool[] inputArray) => inputArray.ForEach(input => forbid.True(input, message));

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> True(this IForbid forbid, Exception exception, params bool[] inputArray) => inputArray.ForEach(input => forbid.True(input, exception));
}