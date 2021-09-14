using System;

namespace Forbid
{
    /// <summary>
    /// A collection of Zero forbid methods for double as extension methods.
    /// </summary>
    public static class ForbidZeroDoubleExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <returns><see cref="double"/> input.</returns>
        public static double Zero(this IForbid forbid, double input) => ForbidZeroDefault.Zero(input);

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <returns><see cref="double"/> input.</returns>
        public static double Zero(this IForbid forbid, double input, string message) =>
            ForbidZeroDefault.Zero(input, message);

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <returns><see cref="double"/> input.</returns>
        public static double Zero(this IForbid forbid, double input, Exception exception) =>
            ForbidZeroDefault.Zero(input, null, exception);
    }
}