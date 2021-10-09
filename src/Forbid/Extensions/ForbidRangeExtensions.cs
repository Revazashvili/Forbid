namespace Forbids
{
    /// <summary>
    /// A collection of Range forbid methods as extension methods.
    /// </summary>
    public static class ForbidRangeExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is between <paramref name="from"/> and <paramref name="to"/>.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="from">The start point of range.</param>
        /// <param name="to">The end point of range.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T Range<T>(this IForbid forbid, T input, T from, T to) 
            where T : struct,IComparable<T>
        {
            return ForbidDefaultExtensions.Range(input, from, to);
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is between <paramref name="from"/> and <paramref name="to"/>.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="from">The start point of range.</param>
        /// <param name="to">The end point of range.</param>
        /// <param name="message">Optional custom message which will be used to throw exception.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T Range<T>(this IForbid forbid, T input, T from, T to,string message)
            where T : struct,IComparable<T>
        {
            return ForbidDefaultExtensions.Range(input, from, to,message);
        }
        
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if <paramref name="input"/> is between <paramref name="from"/> and <paramref name="to"/>.
        /// </summary>
        /// <param name="forbid"><see cref="IForbid"/> interface.</param>
        /// <param name="input">The <see cref="input"/> which will be checked.</param>
        /// <param name="from">The start point of range.</param>
        /// <param name="to">The end point of range.</param>
        /// <param name="exception">An <see cref="Exception"/> which will be thrown if input is null.</param>
        /// <typeparam name="T">Any type of object.</typeparam>
        /// <returns><see cref="T"/> input.</returns>
        public static T Range<T>(this IForbid forbid, T input, T from, T to,Exception exception) 
            where T : struct,IComparable<T>
        {
            return ForbidDefaultExtensions.Range(input, from, to, null, exception);
        }
    }
}