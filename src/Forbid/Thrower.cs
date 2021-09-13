using System;

namespace Forbid
{
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
    }
}