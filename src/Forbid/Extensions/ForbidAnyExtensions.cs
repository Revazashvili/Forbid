namespace Forbids;

/// <summary>
/// A collection of Any forbid methods as extension methods.
/// </summary>
public static class ForbidAnyExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if any element in <paramref name="input"/> satisfies a condition.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">An <see cref="IEnumerable{T}"/> whose elements to apply the predicate to.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static IEnumerable<T> Any<T>(this IForbid forbid, IEnumerable<T> input, Func<T, bool> predicate) => Any(input, predicate);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if any element in <paramref name="input"/> satisfies a condition.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">An <see cref="IEnumerable{T}"/> whose elements to apply the predicate to.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static IEnumerable<T> Any<T>(this IForbid forbid, IEnumerable<T> input, Func<T, bool> predicate, string message) => Any(input, predicate, message);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> if any element in <paramref name="input"/> satisfies a condition.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">An <see cref="IEnumerable{T}"/> whose elements to apply the predicate to.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input satisfies a condition.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static IEnumerable<T> Any<T>(this IForbid forbid, IEnumerable<T> input, Func<T, bool> predicate, Exception exception) => Any(input, predicate, null, exception);
    
    /// <summary>
    /// Check input and throws <see cref="Exception"/> if it's false.
    /// </summary>
    /// <param name="input">An <see cref="IEnumerable{T}"/> whose elements to apply the predicate to.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <returns><see cref="bool"/> value.</returns>
    private static IEnumerable<T> Any<T>(IEnumerable<T> input, Func<T, bool> predicate, string? message = null, Exception? exception = null)
    {
        if (IsNullOrEmpty(message))
        {
            Forbid.From.Null(input, exception);
            Forbid.From.Null(predicate,exception);
        }
        else
        {
            Forbid.From.Null(input, message);
            Forbid.From.Null(predicate,message);
        }
        if (input.Any(predicate))
            ForbidThrower.ThrowWithPriority(nameof(input), message, exception);
        return input;
    }
}
