namespace Forbids;

/// <summary>
/// A collection of NullOrEmpty guid forbid methods as extension methods.
/// </summary>
public static class ForbidNullOrEmptyGuidExtensions
{
    #region Common
    
    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty guid.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="Guid"/> which will be checked.</param>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    /// <returns><see cref="Guid"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty guid.</exception>
    public static Guid NullOrEmpty(this IForbid forbid, Guid? input)
    {
        Forbid.From.Null(input);
        if (input == Guid.Empty)
            throw new ArgumentException(null, nameof(input));
        return input ?? default(Guid);
    }

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty guid.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="Guid"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    /// <returns><see cref="Guid"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty guid.</exception>
    public static Guid NullOrEmpty(this IForbid forbid, Guid? input, string? message)
    {
        Forbid.From.Null(input, message);
        if (input == Guid.Empty)
            throw new ArgumentException(message);
        return input ?? default(Guid);
    }

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty guid.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="Guid"/> which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <returns><see cref="Guid"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty guid.</exception>
    public static Guid NullOrEmpty(this IForbid forbid, Guid? input, Exception? exception)
    {
        Forbid.From.Null(input, exception);
        if (input == Guid.Empty)
            Thrower.ThrowIfNotNull(exception, nameof(input));
        return input ?? default(Guid);
    }

    #endregion

    #region Params

    /// <summary>
    /// Checks if one of <see cref="IEnumerable{T}"/> is empty guid of null and throws exception.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty guid.</exception>
    /// <returns><see cref="IEnumerable{T}"/>.</returns>
    public static IEnumerable<Guid?> NullOrEmpty(this IForbid forbid, params Guid?[] inputArray) =>
        inputArray.ForEach(x=> forbid.NullOrEmpty(x));

    /// <summary>
    /// Checks if one of <see cref="IEnumerable{T}"/> is empty guid of null and throws exception.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty guid.</exception>
    /// <returns><see cref="IEnumerable{T}"/>.</returns>
    public static IEnumerable<Guid> NullOrEmpty(this IForbid forbid, string message, params Guid[] inputArray) =>
        inputArray.ForEach(input => forbid.NullOrEmpty(input, message));

    /// <summary>
    /// Checks if one of <see cref="IEnumerable{T}"/> is empty guid of null and throws exception.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="IEnumerable{T}"/> which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if any input is zero.</param>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty guid.</exception>
    /// <returns><see cref="IEnumerable{T}"/>.</returns>
    public static IEnumerable<Guid> NullOrEmpty(this IForbid forbid, Exception exception, params Guid[] inputArray) =>
        inputArray.ForEach(input => forbid.NullOrEmpty(input, exception));


    #endregion
}