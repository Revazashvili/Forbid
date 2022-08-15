namespace Forbids;

public static class ForbidCountExtensions
{
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> count is equal to passed count.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">An <see cref="IEnumerable{T}"/> whose to forbid count.</param>
    /// <param name="count">The count to be checked.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static IEnumerable<T> Count<T>(this IForbid forbid, IEnumerable<T> input, int count) => Count(input, count);
    
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> count is equal to passed count.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">An <see cref="IEnumerable{T}"/> whose to forbid count.</param>
    /// <param name="count">The count to be checked.</param>
    /// <param name="message">The message used to throw exception.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static IEnumerable<T> Count<T>(this IForbid forbid, IEnumerable<T> input, int count,string message) => Count(input, count,message);
    
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> count is equal to passed count.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">An <see cref="IEnumerable{T}"/> whose to forbid count.</param>
    /// <param name="count">The count to be checked.</param>
    /// <param name="exception">The exception to throw.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    public static IEnumerable<T> Count<T>(this IForbid forbid, IEnumerable<T> input, int count,Exception exception) => Count(input, count,exception:exception);
    
    /// <summary>
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> count is equal to passed count.
    /// </summary>
    /// <param name="input">An <see cref="IEnumerable{T}"/> whose to forbid count.</param>
    /// <param name="count">The count to be checked.</param>
    /// <param name="message">The message used to throw exception.</param>
    /// <param name="exception">The exception to throw.</param>
    /// <typeparam name="T">The type of the elements of source.</typeparam>
    /// <returns><see cref="T"/> input.</returns>
    private static IEnumerable<T> Count<T>(IEnumerable<T> input, int count,string? message = null, Exception? exception = null)
    {
        input = input.ToList();
        Forbid.From.Null(input);
        Forbid.From.Null(count);

        if (input.Count() == count)
            Thrower.ThrowWithPriority(nameof(input), message, exception);
        return input;
    }
}