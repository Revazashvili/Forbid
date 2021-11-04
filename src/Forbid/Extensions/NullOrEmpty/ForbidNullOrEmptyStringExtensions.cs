namespace Forbids;

/// <summary>
/// A collection of NullOrEmpty string forbid methods as extension methods.
/// </summary>
public static class ForbidNullOrEmptyStringExtensions
{
    #region Common
    
    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="string"/> which will be checked.</param>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    /// <returns><see cref="string"/> input.</returns>
    /// <exception cref="ArgumentException"><see cref="Exception"/> which will be thrown if input is empty.</exception>
    public static string NullOrEmpty(this IForbid forbid, string input)
    {
        Forbid.From.Null(input);
        if (input == Empty)
            throw new ArgumentException(nameof(input));
        return input;
    }

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="string"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
    /// <returns><see cref="string"/> input.</returns>
    /// <exception cref="ArgumentException"><see cref="Exception"/> which will be thrown if input is empty.</exception>
    public static string NullOrEmpty(this IForbid forbid, string input, string message)
    {
        Forbid.From.Null(input, message);
        if (input == Empty)
            throw new ArgumentException(message);
        return input;
    }

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
    /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="input">The <see cref="string"/> which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
    /// <returns><see cref="string"/> input.</returns>
    /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty.</exception>
    public static string NullOrEmpty(this IForbid forbid, string input, Exception exception)
    {
        Forbid.From.Null(input, exception);
        if (input == Empty)
            Thrower.ThrowIfNotNull(exception, nameof(input));
        return input;
    }
    
    #endregion

    #region Params

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if one of <paramref name="inputArray"/> is null.
    /// Throws <see cref="ArgumentException"/> if one of <paramref name="inputArray"/> is empty string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <returns>List of passed values</returns>
    public static IEnumerable<string> NullOrEmpty(this IForbid forbid, params string[] inputArray) =>
        inputArray.ForEach(forbid.NullOrEmpty);

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if one of <paramref name="inputArray"/> is null.
    /// Throws <see cref="ArgumentException"/> if one of <paramref name="inputArray"/> is empty string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <param name="message">Optional custom message which will be used to throw exception.</param>
    /// <returns>List of passed values</returns>
    public static IEnumerable<string> NullOrEmpty(this IForbid forbid, string message, params string[] inputArray) =>
        inputArray.ForEach(x => forbid.NullOrEmpty(x, message));

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> if one of <paramref name="inputArray"/> is null.
    /// Throws <see cref="ArgumentException"/> if one of <paramref name="inputArray"/> is empty string.
    /// </summary>
    /// <param name="forbid"><see cref="IForbid"/> interface.</param>
    /// <param name="inputArray">The <see cref="inputArray"/> which will be checked.</param>
    /// <param name="exception">An <see cref="Exception"/> which will be thrown if any input is zero.</param>
    /// <returns>List of passed values</returns>
    public static IEnumerable<string> NullOrEmpty(this IForbid forbid, Exception exception, 
            params string[] inputArray) =>
        inputArray.ForEach(x => forbid.NullOrEmpty(x, exception));

    #endregion
}

