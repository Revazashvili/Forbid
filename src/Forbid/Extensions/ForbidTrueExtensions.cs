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
    public static bool True(this IForbid forbid, bool input, string message) =>
        ForbidDefaultExtensions.True(input, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <returns><see cref="bool"/> input.</returns>
    public static bool True(this IForbid forbid, bool input, Exception exception) =>
        ForbidDefaultExtensions.True(input, null, exception);

    /// <summary>
    ///  Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static bool True(this IForbid forbid, params bool[] inputArray)
    {
        foreach (var input in forbid.NullOrEmpty(inputArray))
            forbid.True(input);
        return true;
    }
    
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static bool True(this IForbid forbid, string message, params bool[] inputArray)
    {
        foreach (var input in forbid.NullOrEmpty(inputArray))
            forbid.True(input,message);
        return true;
    }
    
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is true.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if any input is true.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="inputArray"/></returns>
    public static bool True(this IForbid forbid, Exception exception, params bool[] inputArray)
    {
        foreach (var input in forbid.NullOrEmpty(inputArray))
            forbid.True(input, exception);
        return true;
    }
}

public static class ForeachExtensions
{
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        Forbid.From.NullOrEmpty(source);
        Forbid.From.Null(action);
        foreach (var item in source)
            action(item);
    }
    
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Func<T,T> action)
    {
        Forbid.From.NullOrEmpty(source);
        Forbid.From.Null(action);
        foreach (var item in source)
            yield return action(item);
    }
}