using System;
using System.Collections.Generic;
using System.Linq;
using static System.String;

namespace Forbid
{
    /// <summary>
    /// A collection of NullOrEmpty forbid methods as extension methods.
    /// </summary>
    public static class ForbidNullOrEmptyExtensions
    {
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
                Thrower.ThrowIfNotNull(exception,nameof(input));
            return input;
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is null.
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is empty guid.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="Guid"/> which will be checked.</param>
        /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is null.</exception>
        /// <returns><see cref="Guid"/> input.</returns>
        /// <exception cref="ArgumentNullException"><see cref="Exception"/> which will be thrown if input is empty guid.</exception>
        public static Guid NullOrEmpty(this IForbid forbid, Guid input)
        {
            Forbid.From.Null(input);
            if (input == Guid.Empty)
                throw new ArgumentException(nameof(input));
            return input;
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
        public static Guid NullOrEmpty(this IForbid forbid, Guid input, string message)
        {
            Forbid.From.Null(input, message);
            if (input == Guid.Empty)
                throw new ArgumentException(message);
            return input;
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
        public static Guid NullOrEmpty(this IForbid forbid, Guid input, Exception exception)
        {
            Forbid.From.Null(input, exception);
            if (input == Guid.Empty)
                Thrower.ThrowIfNotNull(exception,nameof(input));
            return input;
        }
        
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
        public static IEnumerable<T> NullOrEmpty<T>(this IForbid forbid, IEnumerable<T> input)
        {
            Forbid.From.Null(input);
            if (!input.Any())
                throw new ArgumentException(nameof(input));
            return input;
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
        public static IEnumerable<T> NullOrEmpty<T>(this IForbid forbid, IEnumerable<T> input, string message)
        {
            Forbid.From.Null(input, message);
            if (!input.Any())
                throw new ArgumentException(message);
            return input;
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
        public static IEnumerable<T> NullOrEmpty<T>(this IForbid forbid, IEnumerable<T> input, Exception exception)
        {
            Forbid.From.Null(input, exception);
            if (!input.Any())
                Thrower.ThrowIfNotNull(exception, nameof(input));
            return input;
        }
    }
}