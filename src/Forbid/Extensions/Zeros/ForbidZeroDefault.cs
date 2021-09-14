using System;
using System.Collections.Generic;

namespace Forbid
{
    /// <summary>
    /// Extension class to forbid input from it's default value.
    /// </summary>
    internal static class ForbidZeroDefault
    {
        /// <summary>
        /// Uses <see cref="EqualityComparer{T}"/> to check input value is default or not and throws <see cref="Exception"/>.
        /// </summary>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        /// <exception cref="ArgumentException"><see cref="Exception"/> which will be thrown if input is null.</exception>
        internal static T Zero<T>(T input, string? message = null, Exception? exception = null) where T : struct
        {
            Forbid.From.Null(input);
            if (EqualityComparer<T>.Default.Equals(input, default))
                Thrower.ThrowWithPriority(nameof(input), message, exception);
            return input;
        }
    }
}