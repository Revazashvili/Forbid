namespace Forbids
{

    /// <summary>
    /// Class where extension methods will be called.
    /// </summary>
    public class Forbid : IForbid
    {
        /// <summary>
        /// An entry point for extension methods.
        /// </summary>
        public static IForbid From { get; } = new Forbid();
    }
}