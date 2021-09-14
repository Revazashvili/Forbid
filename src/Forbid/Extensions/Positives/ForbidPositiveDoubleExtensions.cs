﻿using System;

namespace Forbid
{
    /// <summary>
    /// A collection of Negative forbid methods for double as extension methods.
    /// </summary>
    public static class ForbidPositiveDoubleExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is positive.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <returns><see cref="double"/> input.</returns>
        public static double Positive(this IForbid forbid, double input) => ForbidPositiveDefault.Positive(input);

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is positive.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <returns><see cref="double"/> input.</returns>
        public static double Positive(this IForbid forbid, double input, string message) =>
            ForbidPositiveDefault.Positive(input, message);

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is positive.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <returns><see cref="double"/> input.</returns>
        public static double Positive(this IForbid forbid, double input, Exception exception) =>
            ForbidPositiveDefault.Positive(input, null, exception);
    }
}