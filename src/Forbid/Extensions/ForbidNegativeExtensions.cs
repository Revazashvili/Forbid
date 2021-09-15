using System;

namespace Forbids
{
    /// <summary>
    /// A collection of Negative forbid methods as extension methods.
    /// </summary>
    public static class ForbidNegativeExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T Negative<T>(this IForbid forbid,T input)
            where T : struct, IComparable<T>
        {
            return ForbidDefaultExtensions.Negative(input);
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T Negative<T>(this IForbid forbid,T input, string message)
            where T : struct, IComparable<T>
        {
            return ForbidDefaultExtensions.Negative(input,message);
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T Negative<T>(this IForbid forbid,T input,Exception exception)
            where T : struct, IComparable<T>
        {
            return ForbidDefaultExtensions.Negative(input, null, exception);
        }
    }
}