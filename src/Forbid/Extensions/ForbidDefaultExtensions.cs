using System.Linq;

namespace Forbids;

/// <summary>
/// A collection of default forbid methods as extensions.
/// </summary>
internal static class ForbidDefaultExtensions
{
    /// <summary>
    /// Uses <see cref="EqualityComparer{T}"/> to check if input value are equal to each other throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="x">The first parameter to compare.</param>
    /// <param name="y">The second parameter to compare.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    /// <exception cref="ArgumentException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    internal static T Equal<T>(T x, T y, string? message = null, Exception? exception = null) where T : struct, IComparable<T>
    {
        Forbid.From.Null(x);
        Forbid.From.Null(y);
        if (EqualityComparer<T>.Default.Equals(x, y))
            Thrower.ThrowWithPriority(nameof(x), message, exception);
        return x;
    }

    /// <summary>
    /// Uses <see cref="IComparable"/> to check if input value is positive and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    internal static T Positive<T>(T input, string? message = null, Exception? exception = null) where T : struct, IComparable<T>
    {
        Forbid.From.Null(input);
        if (input.CompareTo(default(T)) > 0)
            Thrower.ThrowWithPriority(nameof(input), message, exception);
        return input;
    }

    /// <summary>
    /// Uses <see cref="IComparable{T}"/> to check if input value is negative and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    internal static T Negative<T>(T input, string? message = null, Exception? exception = null) where T : struct, IComparable<T>
    {
        Forbid.From.Null(input);
        if (input.CompareTo(default(T)) < 0)
            Thrower.ThrowWithPriority(nameof(input), message, exception);
        return input;
    }

    /// <summary>
    /// Uses <see cref="IComparable{T}"/> to check if input value is negative or zero and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    internal static T NegativeOrZero<T>(T input, string? message = null, Exception? exception = null) where T : struct, IComparable<T>
    {
        Forbid.From.Null(input);
        Negative(input, message, exception);
        ForbidZeroExtensions.Zero(input, message, exception);
        return input;
    }

    /// <summary>
    /// Uses <see cref="IComparable{T}"/> to check if input value is positive or zero and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="input">The <see cref="input"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    internal static T PositiveOrZero<T>(T input, string? message = null, Exception? exception = null)
        where T : struct, IComparable<T>
    {
        Forbid.From.Null(input);
        Positive(input, message, exception);
        ForbidZeroExtensions.Zero(input, message, exception);
        return input;
    }
}
