using System;

namespace Forbid
{
    /// <summary>
    /// A collection of Zero forbid methods for decimal as extension methods.
    /// </summary>
    public static class ForbidZeroDecimalExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <returns><see cref="decimal"/> input.</returns>
        public static decimal Zero(this IForbid forbid, decimal input) => ForbidZeroDefault.Zero(input);

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <returns><see cref="decimal"/> input.</returns>
        public static decimal Zero(this IForbid forbid, decimal input, string message) =>
            ForbidZeroDefault.Zero(input, message);

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <returns><see cref="decimal"/> input.</returns>
        public static decimal Zero(this IForbid forbid, decimal input, Exception exception) =>
            ForbidZeroDefault.Zero(input, null, exception);
    }
}