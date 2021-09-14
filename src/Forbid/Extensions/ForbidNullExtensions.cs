using System;

namespace Forbid
{
    /// <summary>
    /// A collection of Null forbid methods as extension methods.
    /// </summary>
    public static class ForbidNullExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
        public static T Null<T>(this IForbid forbid, T input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));
            return input;
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
        public static T Null<T>(this IForbid forbid, T input,string message)
        {
            if (input is null)
                Thrower.ThrowIfNotNull(message,nameof(input));
            return input;
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T Null<T>(this IForbid forbid, T input,Exception exception)
        {
            if (input is null)
                Thrower.ThrowIfNotNull(exception,nameof(input));
            return input;
        }
    }
}