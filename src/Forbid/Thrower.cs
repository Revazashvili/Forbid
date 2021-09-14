﻿using System;

namespace Forbid
{
    /// <summary>
    /// A collection of methods for throwing some kind of <see cref="Exception"/>.
    /// </summary>
    internal static class Thrower
    {
        /// <summary>
        /// Throws provided exception if not null.
        /// if it's null method will throw <see cref="ArgumentNullException"/>.
        /// </summary>
        /// <param name="exception">The Exception to be thrown</param>
        /// <param name="nameOf">The name of parameter. Used to throw <see cref="ArgumentNullException"/> if provided exception is null.</param>
        /// <exception cref="Exception">Provided <see cref="Exception"/> to be thrown.</exception>
        /// <exception cref="ArgumentNullException"><see cref="ArgumentNullException"/> thrown if provided exception is null.</exception>
        internal static void ThrowIfNotNull(Exception? exception,string nameOf)
        {
            if (exception is not null)
                throw exception;
            throw new ArgumentException(nameOf);
        }

        /// <summary>
        /// Throws provided message as exception if not null or empty.
        /// if it's null method will throw <see cref="ArgumentNullException"/>.
        /// </summary>
        /// <param name="message">The message which will be thrown in <see cref="Exception"/>.</param>
        /// <param name="nameOf">The name of parameter. Used to throw <see cref="ArgumentNullException"/> if provided exception is null.</param>
        /// <exception cref="Exception">Provided <see cref="Exception"/> to be thrown.</exception>
        /// <exception cref="ArgumentNullException"><see cref="ArgumentNullException"/> thrown if provided exception is null.</exception>
        internal static void ThrowIfNotNull(string message,string nameOf)
        {
            if (!string.IsNullOrEmpty(message))
                throw new ArgumentNullException(message);
            throw new ArgumentNullException(nameOf);
        }

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if message and exception is null,
        /// otherwise throws <paramref name="exception"/> and,
        /// finally throws message as exception if provided exception is null.
        /// </summary>
        /// <param name="message">The message which will be thrown in <see cref="Exception"/>.</param>
        /// <param name="nameOf">The name of parameter. Used to throw <see cref="ArgumentNullException"/> if provided exception is null.</param>
        /// <exception cref="Exception">Provided <see cref="Exception"/> to be thrown.</exception>
        /// <exception cref="ArgumentNullException"><see cref="ArgumentNullException"/> thrown if provided exception and message is null.</exception>
        internal static void ThrowWithPriority(string nameOf, string? message = null, Exception? exception = null)
        {
            if (string.IsNullOrEmpty(message) && exception is null)
                throw new ArgumentNullException(nameOf);
            if (exception is not null)
                Thrower.ThrowIfNotNull(exception, nameOf);
            if (!string.IsNullOrEmpty(message))
                Thrower.ThrowIfNotNull(message, nameOf);
        }
    }
}