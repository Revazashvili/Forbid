﻿namespace Forbids;

/// <summary>
/// A collection of Equal forbid methods as extension methods.
/// </summary>
public static class ForbidEqualExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="x"/> and <paramref name="y"/> are equal.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="x">The first parameter to compare.</param>
    /// <param name="y">The second parameter to compare.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Equal<T>(this IForbid forbid, T x, T y) where T : struct, IComparable<T> =>
        ForbidDefaultExtensions.Equal(x, y);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="x"/> and <paramref name="y"/> are equal.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="x">The first parameter to compare.</param>
    /// <param name="y">The second parameter to compare.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Equal<T>(this IForbid forbid, T x, T y, string message) where T : struct, IComparable<T> =>
        ForbidDefaultExtensions.Equal(x, y, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="x"/> and <paramref name="y"/> are equal.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="x">The first parameter to compare.</param>
    /// <param name="y">The second parameter to compare.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if inputs are equal.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static T Equal<T>(this IForbid forbid, T x, T y, Exception exception) where T : struct, IComparable<T> =>
        ForbidDefaultExtensions.Equal(x, y, null, exception);
}
