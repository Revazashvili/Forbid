using System;
using System.Collections.Generic;

namespace Forbid
{
    /// <summary>
    /// Extension class to forbid input zero from it's default value.
    /// </summary>
    internal static class ForbidZeroDefault
    {
        /// <summary>
        /// Uses <see cref="EqualityComparer{T}"/> to check input value is default or not.
        /// Throws <see cref="ArgumentNullException"/> if message and exception is null,
        /// otherwise throws <paramref name="exception"/> and,
        /// finally throws message as exception if provided exception is null.
        /// </summary>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception if <paramref name="exception"/> is null.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
        internal static T Zero<T>(T input,string? message = null,Exception? exception = null)
        {
            if (EqualityComparer<T>.Default.Equals(input, default!))
            {
                if(string.IsNullOrEmpty(message) && exception is null)
                    throw new ArgumentNullException(nameof(input));
                if(exception is not null)
                    Thrower.ThrowIfNotNull(exception,nameof(input));
                if(!string.IsNullOrEmpty(message))
                    Thrower.ThrowIfNotNull(message,nameof(input));
            }

            return input;
        }
    }
}