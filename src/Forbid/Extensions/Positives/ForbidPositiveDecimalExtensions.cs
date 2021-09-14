﻿using System;

namespace Forbid
{
    /// <summary>
    /// A collection of Negative forbid methods for decimal as extension methods.
    /// </summary>
    public static class ForbidPositiveDecimalExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is positive.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <returns><see cref="decimal"/> input.</returns>
        public static decimal Positive(this IForbid forbid, decimal input) => ForbidPositiveDefault.Positive(input);

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is positive.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <returns><see cref="decimal"/> input.</returns>
        public static decimal Positive(this IForbid forbid, decimal input, string message) =>
            ForbidPositiveDefault.Positive(input, message);

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is positive.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <returns><see cref="decimal"/> input.</returns>
        public static decimal Positive(this IForbid forbid, decimal input, Exception exception) =>
            ForbidPositiveDefault.Positive(input, null, exception);
    }
}