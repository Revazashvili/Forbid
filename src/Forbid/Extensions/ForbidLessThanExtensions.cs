namespace Forbids;

/// <summary>
/// A collection of LessThan forbid methods as extension methods.
/// </summary>
public static class ForbidLessThanExtensions
{
    /// <summary>
    ///  Throws <see cref="ArgumentException"/> if <paramref name="input"/> is less than second parameter.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="valueToCompare">The parameter to compare.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T LessThan<T>(this IForbid forbid, T input, T valueToCompare)
        where T : struct, IComparable<T> => LessThan(input, valueToCompare);

    /// <summary>
    ///  Throws <see cref="ArgumentException"/> if <paramref name="input"/> is less than second parameter.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="valueToCompare">The parameter to compare.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T LessThan<T>(this IForbid forbid, T input, T valueToCompare, string message)
        where T : struct, IComparable<T> => LessThan(input, valueToCompare, message);

    /// <summary>
    ///  Throws <see cref="ArgumentException"/> if <paramref name="input"/> is less than second parameter.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="valueToCompare">The parameter to compare.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T LessThan<T>(this IForbid forbid, T input, T valueToCompare, Exception exception)
        where T : struct, IComparable<T> => LessThan(input, valueToCompare, null, exception);
    
    /// <summary>
    /// Uses <see cref="IComparable{T}"/> to check input if value is less than second  and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="x">The <see cref="x"/> which will be checked.</param>
    /// <param name="y">The parameter used to compare.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    private static T LessThan<T>(T x, T y, string? message = null, Exception? exception = null)
        where T : struct, IComparable<T>
    {
        Forbid.From.Null(x);
        Forbid.From.Null(y);
        if (x.CompareTo(y) < 0)
            Thrower.ThrowWithPriority(nameof(x), message, exception);
        return x;
    }
}
