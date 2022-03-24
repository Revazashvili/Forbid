namespace Forbids;

/// <summary>
/// A collection of Positive or Zero forbid methods as extension methods.
/// </summary>
public static class ForbidPositiveOrZeroExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is positive or zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T PositiveOrZero<T>(this IForbid forbid, T input)
        where T : struct, IComparable<T> => PositiveOrZero(input);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is positive or zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T PositiveOrZero<T>(this IForbid forbid, T input, string message)
        where T : struct, IComparable<T> => PositiveOrZero(input, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is positive or zero.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The input which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T PositiveOrZero<T>(this IForbid forbid, T input, Exception exception)
        where T : struct, IComparable<T> => PositiveOrZero(input, null, exception);
    
    /// <summary>
    /// Uses <see cref="IComparable{T}"/> to check if input value is positive or zero and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    private static T PositiveOrZero<T>(T input, string? message = null, Exception? exception = null)
        where T : struct, IComparable<T>
    {
        Forbid.From.Null(input);
        ForbidDefaultExtensions.Positive(input, message, exception);
        ForbidZeroExtensions.Zero(input, message, exception);
        return input;
    }
}
