namespace Forbids
{
    /// <summary>
    /// A collection of Any forbid methods as extension methods.
    /// </summary>
    public static class ForbidAnyExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if any element in <paramref name="input"/> satisfies a condition.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">An <see cref="IEnumerable{T}"/> whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static IEnumerable<T> Any<T>(this IForbid forbid, IEnumerable<T> input, Func<T, bool> predicate) =>
            ForbidDefaultExtensions.Any(input, predicate);

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if any element in <paramref name="input"/> satisfies a condition.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">An <see cref="IEnumerable{T}"/> whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static IEnumerable<T> Any<T>(this IForbid forbid, IEnumerable<T> input, Func<T, bool> predicate,
            string message) => ForbidDefaultExtensions.Any(input, predicate, message);

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if any element in <paramref name="input"/> satisfies a condition.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">An <see cref="IEnumerable{T}"/> whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static IEnumerable<T> Any<T>(this IForbid forbid, IEnumerable<T> input, Func<T, bool> predicate,
            Exception exception) => ForbidDefaultExtensions.Any(input, predicate, null, exception);
    }
}