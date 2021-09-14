using System;

namespace Forbid
{
    /// <summary>
    /// A collection of MoreThanOrEqual forbid methods as extension methods.
    /// </summary>
    public static class ForbidMoreThanOrEqualExtensions
    {
        /// <summary>
        ///  Throws <see cref="ArgumentException"/> if <paramref name="input"/> is more than or equal second parameter.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <param name="valueToCompare">The parameter to compare.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T MoreThanOrEqual<T>(this IForbid forbid, T input, T valueToCompare)
            where T : struct, IComparable<T>
        {
            return ForbidDefaultExtensions.MoreThanOrEqual(input,valueToCompare);
        }
        
        /// <summary>
        ///  Throws <see cref="ArgumentException"/> if <paramref name="input"/> is more than or equal second parameter.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <param name="valueToCompare">The parameter to compare.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T MoreThanOrEqual<T>(this IForbid forbid, T input, T valueToCompare,string message)
            where T : struct, IComparable<T>
        {
            return ForbidDefaultExtensions.MoreThanOrEqual(input,valueToCompare,message);
        }
        
        /// <summary>
        ///  Throws <see cref="ArgumentException"/> if <paramref name="input"/> is than or equal than second parameter.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <param name="valueToCompare">The parameter to compare.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T MoreThanOrEqual<T>(this IForbid forbid, T input, T valueToCompare,Exception exception)
            where T : struct, IComparable<T>
        {
            return ForbidDefaultExtensions.MoreThanOrEqual(input,valueToCompare,null,exception);
        }
    }
}