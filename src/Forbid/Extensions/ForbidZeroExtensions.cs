namespace Forbids;

/// <summary>
/// A collection of Zero forbid methods as extension methods.
/// </summary>
public static class ForbidZeroExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Zero<T>(this IForbid forbid, T input)
        where T : struct, IComparable<T> => Zero(input);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Zero<T>(this IForbid forbid, T input, string message)
        where T : struct, IComparable<T> => Zero(input, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Zero<T>(this IForbid forbid, T input, Exception exception)
        where T : struct, IComparable<T> => Zero(input, null, exception);

    /// <summary>
    ///  Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<T> Zero<T>(this IForbid forbid, params T[] inputArray)
        where T : struct, IComparable<T> => inputArray.ForEach(forbid.Zero);


    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <param name="inputArray">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<T> Zero<T>(this IForbid forbid, string message, params T[] inputArray)
        where T : struct, IComparable<T> => inputArray.ForEach(input => forbid.Zero(input, message));


    /// <summary>
    /// Throws <see cref="ArgumentException"/> if one of input in <paramref name="inputArray"/> is zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if any input is zero.</param>
    /// <param name="inputArray">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<T> Zero<T>(this IForbid forbid, Exception exception, params T[] inputArray)
        where T : struct, IComparable<T> => inputArray.ForEach(input => forbid.Zero(input, exception));
    
    /// <summary>
    /// Uses <see cref="EqualityComparer{T}"/> to check if input value is zero and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    /// <exception cref="ArgumentException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    internal static T Zero<T>(T input, string? message = null, Exception? exception = null) where T : struct, IComparable<T>
    {
        Forbid.From.Null(input);
        if (EqualityComparer<T>.Default.Equals(input, default))
            Thrower.ThrowWithPriority(nameof(input), message, exception);
        return input;
    }
}
