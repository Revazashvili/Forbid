﻿using System;

namespace Forbid
{
    /// <summary>
    /// A collection of Zero forbid methods for long as extension methods.
    /// </summary>
    public static class ForbidZeroLongExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <returns><see cref="long"/> input.</returns>
        public static long Zero(this IForbid forbid, long input) => ForbidZeroDefault.Zero(input);

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <returns><see cref="long"/> input.</returns>
        public static long Zero(this IForbid forbid, long input, string message) =>
            ForbidZeroDefault.Zero(input, message);

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is zero.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <returns><see cref="long"/> input.</returns>
        public static long Zero(this IForbid forbid, long input, Exception exception) =>
            ForbidZeroDefault.Zero(input, null, exception);
    }
}