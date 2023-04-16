namespace Forbids;

/// <summary>
/// A collection of NullOrEmpty IEnumerable forbid methods as extension methods.
/// </summary>
public static class ForbidNullOrEmptyIEnumerableExtensions
{
    #region Common
    
    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty list.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    /// <returns><see cref="IEnumerable{T}"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty list.</exception>
    public static IEnumerable<T> NullOrEmpty<T>(this IForbid forbid, IEnumerable<T>? input)
    {
        Forbid.From.Null(input);
        if (!input!.Any())
            throw new ArgumentException(nameof(input));
        return input!;
    }

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty list.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    /// <returns><see cref="IEnumerable{T}"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty list.</exception>
    public static IEnumerable<T> NullOrEmpty<T>(this IForbid forbid, IEnumerable<T>? input, string? message)
    {
        Forbid.From.Null(input, message);
        if (!input!.Any())
            throw new ArgumentException(message);
        return input!;
    }

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty list.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <typeparam name="T">Any type of object.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    /// <returns><see cref="IEnumerable{T}"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    public static IEnumerable<T> NullOrEmpty<T>(this IForbid forbid, IEnumerable<T>? input, Exception? exception)
    {
        Forbid.From.Null(input, exception);
        if (!input!.Any())
            ForbidThrower.ThrowIfNotNull(exception, nameof(input));
        return input!;
    }
    
    #endregion
}