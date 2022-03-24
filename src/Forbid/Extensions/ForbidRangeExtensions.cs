namespace Forbids;

/// <summary>
/// A collection of Range forbid methods as extension methods.
/// </summary>
public static class ForbidRangeExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is between <paramref name="from"/> and <paramref name="to"/>.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="from">The start point of range.</param>
    /// <param name="to">The end point of range.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Range<T>(this IForbid forbid, T input, T from, T to)
        where T : struct, IComparable<T> => Range(input, from, to);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is between <paramref name="from"/> and <paramref name="to"/>.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="from">The start point of range.</param>
    /// <param name="to">The end point of range.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Range<T>(this IForbid forbid, T input, T from, T to, string message)
        where T : struct, IComparable<T> => Range(input, from, to, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is between <paramref name="from"/> and <paramref name="to"/>.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="from">The start point of range.</param>
    /// <param name="to">The end point of range.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Range<T>(this IForbid forbid, T input, T from, T to, Exception exception)
        where T : struct, IComparable<T> => Range(input, from, to, null, exception);
    
    /// <summary>
    /// Uses <see cref="IComparable{T}"/> to check input if value is in range of <paramref name="from"/> and <paramref name="to"/> and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="x">The <see cref="x"/> which will be checked.</param>
    /// <param name="from">The start point of range.</param>
    /// <param name="to">The end point of range.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    private static T Range<T>(T x, T from, T to, string? message = null, Exception? exception = null)
        where T : struct, IComparable<T>
    {
        Forbid.From.Null(x);
        Forbid.From.Null(from);
        Forbid.From.Null(to);
        ForbidEqualExtensions.Equal(from, to, message, exception);
        // if (from < x < to), then throw exception
        if (x.CompareTo(from) > 0 && x.CompareTo(to) < 0)
            Thrower.ThrowWithPriority(nameof(x), message, exception);
        return x;
    }
}
