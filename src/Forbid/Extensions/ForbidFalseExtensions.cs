using System;

namespace Forbids
{
    /// <summary>
    /// A collection of False forbid methods as extension methods.
    /// </summary>
    public static class ForbidFalseExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is false.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <returns><see cref="bool"/> input.</returns>
        public static bool False(this IForbid forbid,bool input)
        {
            return ForbidDefaultExtensions.False(input);
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is false.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <returns><see cref="bool"/> input.</returns>
        public static bool False(this IForbid forbid,bool input,string message)
        {
            return ForbidDefaultExtensions.False(input,message);
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is false.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The input which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <returns><see cref="bool"/> input.</returns>
        public static bool False(this IForbid forbid,bool input,Exception exception)
        {
            return ForbidDefaultExtensions.False(input, null, exception);
        }
    }
}