﻿using System;

namespace Forbid
{
    /// <summary>
    /// A collection of Negative forbid methods for float as extension methods.
    /// </summary>
    public static class ForbidNegativeFloatExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <returns><see cref="float"/> input.</returns>
        public static float Negative(this IForbid forbid, float input) => ForbidNegativeDefault.Negative(input);

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <returns><see cref="float"/> input.</returns>
        public static float Negative(this IForbid forbid, float input, string message) =>
            ForbidNegativeDefault.Negative(input, message);

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <returns><see cref="float"/> input.</returns>
        public static float Negative(this IForbid forbid, float input, Exception exception) =>
            ForbidNegativeDefault.Negative(input, null, exception);
    }
}