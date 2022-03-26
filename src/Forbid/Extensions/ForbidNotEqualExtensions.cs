﻿namespace Forbids;

/// <summary>
/// A collection of Not Equal forbid methods as extension methods.
/// </summary>
public static class ForbidNotEqualExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="x"/> and <paramref name="y"/> are not equal.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="x">The first parameter to compare.</param>
    /// <param name="y">The second parameter to compare.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T NotEqual<T>(this IForbid forbid, T x, T y) where T : struct, IComparable<T> => NotEqual(x, y);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="x"/> and <paramref name="y"/> are not equal.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="x">The first parameter to compare.</param>
    /// <param name="y">The second parameter to compare.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T NotEqual<T>(this IForbid forbid, T x, T y, string message) where T : struct, IComparable<T> => NotEqual(x, y, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="x"/> and <paramref name="y"/> are not equal.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="x">The first parameter to compare.</param>
    /// <param name="y">The second parameter to compare.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T NotEqual<T>(this IForbid forbid, T x, T y, Exception exception) where T : struct, IComparable<T> => NotEqual(x, y, null, exception);
    
    /// <summary>
    /// Uses <see cref="EqualityComparer{T}"/> to check if input value are not equal to each other and throws <see cref="Exception"/>.
    /// </summary>
    /// <param name="x">The first parameter to compare.</param>
    /// <param name="y">The second parameter to compare.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    /// <exception cref="ArgumentException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    private static T NotEqual<T>(T x, T y, string? message = null, Exception? exception = null) where T : struct, IComparable<T>
    {
        Forbid.From.Null(x);
        Forbid.From.Null(y);
        if (!EqualityComparer<T>.Default.Equals(x, y))
            Thrower.ThrowWithPriority(nameof(x), message, exception);
        return x;
    }
}
