using System;

namespace Forbid
{
    /// <summary>
    /// Extension class to forbid input more than it's default value.
    /// </summary>
    public static class ForbidPositiveDefault
    {
        /// <summary>
        /// Uses <see cref="IComparable"/> to check input value is positive and throws <see cref="Exception"/>.
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
    }
}