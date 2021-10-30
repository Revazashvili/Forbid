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
    public static bool False(this IForbid forbid, bool input) => ForbidDefaultExtensions.False(input);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool False(this IForbid forbid, bool input, string message) =>
        ForbidDefaultExtensions.False(input, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is false.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool False(this IForbid forbid, bool input, Exception exception) =>
        ForbidDefaultExtensions.False(input, null, exception);

    /// <summary>
    ///  Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> False(this IForbid forbid, params bool[] inputArray) =>
        forbid.NullOrEmpty(inputArray).ForEach(forbid.False);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> False(this IForbid forbid, string message, params bool[] inputArray) =>
        forbid.NullOrEmpty(inputArray).ForEach(x => forbid.False(x, message));

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is false.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static IEnumerable<bool> False(this IForbid forbid, Exception exception, params bool[] inputArray) =>
        forbid.NullOrEmpty(inputArray).ForEach(x => forbid.False(x, exception));

}
